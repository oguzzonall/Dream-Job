namespace CareerPortal.MvcWebUI.Helper.Alert.AlertifyJs
{
    public static class AlertifyHelper
    {
        public static string SuccessMessage(string message = "")
        {
            return $"<script >alertify.success(\"" + message + "\" ); </script>";
        }


        public static string ErrorMessage(string message = "")
        {
            return $"<script >alertify.error(\"" + message + "\" ); </script>";
        }

        public static string InfoMessage(string message = "")
        {
            return $"<script >alertify.message(\"" + message + "\" ); </script>";
        }

        public static string WarningMessage(string message = "")
        {
            return $"<script >alertify.warning(\"" + message + "\" ); </script>";
        }
    }
}
