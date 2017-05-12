namespace GS.module.entities.Base
{
    using Primary;
    using System;
    using System.Collections.Generic;
    using System.Security.Cryptography;
    using System.Text;
    public static class Helper
    {
        public static Transaction InitTransaction()
        {
            return new Transaction();
        }
        public static Transaction GetTransaction(TypeTransaction type, string message)
        {
            Transaction transaction = new Transaction()
            {
                Type = type
            };
            if (message.Contains("ORA-"))
            {
                transaction.Message = message.Replace(Char.ConvertFromUtf32(34), "").Replace(Char.ConvertFromUtf32(10), "\\n").Replace(Char.ConvertFromUtf32(13), "\\n");
            }
            else
            {
                transaction.Message = message;
            }
            return transaction;
        }
        public static string InvokeSuccesHTML(string _message)
        {
            return String.Format("<script language=\"javascript\">showSuccess(\"{0}\");</script>", _message);
        }
        public static string InvokeErrorHTML(string _message)
        {
            return String.Format("<script language=\"javascript\">showError(\"{0}\");</script>", _message);
        }
        public static string InvokeTextHTML(string _html)
        {
            return String.Format("<script language=\"javascript\">{0}</script>", _html);
        }
        public static string InitFilter(List<object> _params)
        {
            string formatFilter = "";
            foreach (var _param in _params)
            {
                if (_param.ToString() == "0" || _param.ToString() == string.Empty)
                    formatFilter = formatFilter + "0";
                else
                    formatFilter = formatFilter + "1";
            }
            return formatFilter;
        }
        public static string Desencriptar(string key, string textoEncriptado)
        {
            try
            {
                byte[] keyArray;
                byte[] Array_a_Descifrar = Convert.FromBase64String(textoEncriptado);

                //algoritmo MD5
                MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();

                keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));

                hashmd5.Clear();

                TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();

                tdes.Key = keyArray;
                tdes.Mode = CipherMode.ECB;
                tdes.Padding = PaddingMode.PKCS7;

                ICryptoTransform cTransform = tdes.CreateDecryptor();

                byte[] resultArray = cTransform.TransformFinalBlock(Array_a_Descifrar, 0, Array_a_Descifrar.Length);

                tdes.Clear();
                textoEncriptado = UTF8Encoding.UTF8.GetString(resultArray);

            }
            catch (Exception)
            {

            }
            return textoEncriptado;
        }
        public static string Encriptar(string key, string texto)
        {
            try
            {

                byte[] keyArray;

                byte[] Arreglo_a_Cifrar = UTF8Encoding.UTF8.GetBytes(texto);

                //Se utilizan las clases de encriptación MD5

                MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();

                keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));

                hashmd5.Clear();

                //Algoritmo TripleDES
                TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();

                tdes.Key = keyArray;
                tdes.Mode = CipherMode.ECB;
                tdes.Padding = PaddingMode.PKCS7;

                ICryptoTransform cTransform = tdes.CreateEncryptor();

                byte[] ArrayResultado = cTransform.TransformFinalBlock(Arreglo_a_Cifrar, 0, Arreglo_a_Cifrar.Length);

                tdes.Clear();

                //se regresa el resultado en forma de una cadena
                texto = Convert.ToBase64String(ArrayResultado, 0, ArrayResultado.Length);

            }
            catch (Exception)
            {

            }
            return texto;
        }
    }
}
