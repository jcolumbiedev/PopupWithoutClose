namespace PopupWithoutClose.Module.Win.Controllers
{
    partial class popupmanager
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
            this.popuptest = new DevExpress.ExpressApp.Actions.PopupWindowShowAction(this.components);
            // 
            // popuptest
            // 
            this.popuptest.AcceptButtonCaption = "Ok";
            this.popuptest.ActionMeaning = DevExpress.ExpressApp.Actions.ActionMeaning.Accept;
            this.popuptest.Caption = "Desea Cerrar";
            this.popuptest.Category = "Edit";
            this.popuptest.ConfirmationMessage = null;
            this.popuptest.Id = "popuptest";
            this.popuptest.ToolTip = null;
            this.popuptest.TypeOfView = typeof(DevExpress.ExpressApp.View);
            this.popuptest.CustomizePopupWindowParams += new DevExpress.ExpressApp.Actions.CustomizePopupWindowParamsEventHandler(this.popuptest_CustomizePopupWindowParams);
            this.popuptest.CustomizeTemplate += new System.EventHandler<DevExpress.ExpressApp.CustomizeTemplateEventArgs>(this.popuptest_CustomizeTemplate);
            // 
            // popupmanager
            // 
            this.Actions.Add(this.popuptest);
            this.TargetObjectType = typeof(PopupWithoutClose.Module.BusinessObjects.Nota);

        }

        #endregion

        private DevExpress.ExpressApp.Actions.PopupWindowShowAction popuptest;
    }
}
