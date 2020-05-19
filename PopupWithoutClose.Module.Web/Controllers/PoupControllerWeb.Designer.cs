namespace PopupWithoutClose.Module.Web.Controllers
{
    partial class PoupControllerWeb
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PopupWeb = new DevExpress.ExpressApp.Actions.PopupWindowShowAction(this.components);
            // 
            // PopupWeb
            // 
            this.PopupWeb.AcceptButtonCaption = null;
            this.PopupWeb.ActionMeaning = DevExpress.ExpressApp.Actions.ActionMeaning.Accept;
            this.PopupWeb.CancelButtonCaption = null;
            this.PopupWeb.Caption = "Acepta Los terminos";
            this.PopupWeb.Category = "Edit";
            this.PopupWeb.ConfirmationMessage = null;
            this.PopupWeb.Id = "PopupWeb";
            this.PopupWeb.TargetObjectType = typeof(PopupWithoutClose.Module.BusinessObjects.Nota);
            this.PopupWeb.ToolTip = null;
            this.PopupWeb.CustomizePopupWindowParams += new DevExpress.ExpressApp.Actions.CustomizePopupWindowParamsEventHandler(this.PopupWeb_CustomizePopupWindowParams);
            // 
            // PoupControllerWeb
            // 
            this.Actions.Add(this.PopupWeb);

        }

        #endregion

        private DevExpress.ExpressApp.Actions.PopupWindowShowAction PopupWeb;
    }
}
