﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsService.ServiceRef {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="New", Namespace="http://schemas.datacontract.org/2004/07/DAL_Library")]
    [System.SerializableAttribute()]
    public partial class New : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> DepositDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WindowsService.ServiceRef.NewsImage[] NewsImagesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SubTitleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TextField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TitleField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> DepositDate {
            get {
                return this.DepositDateField;
            }
            set {
                if ((this.DepositDateField.Equals(value) != true)) {
                    this.DepositDateField = value;
                    this.RaisePropertyChanged("DepositDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WindowsService.ServiceRef.NewsImage[] NewsImages {
            get {
                return this.NewsImagesField;
            }
            set {
                if ((object.ReferenceEquals(this.NewsImagesField, value) != true)) {
                    this.NewsImagesField = value;
                    this.RaisePropertyChanged("NewsImages");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SubTitle {
            get {
                return this.SubTitleField;
            }
            set {
                if ((object.ReferenceEquals(this.SubTitleField, value) != true)) {
                    this.SubTitleField = value;
                    this.RaisePropertyChanged("SubTitle");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Text {
            get {
                return this.TextField;
            }
            set {
                if ((object.ReferenceEquals(this.TextField, value) != true)) {
                    this.TextField = value;
                    this.RaisePropertyChanged("Text");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Title {
            get {
                return this.TitleField;
            }
            set {
                if ((object.ReferenceEquals(this.TitleField, value) != true)) {
                    this.TitleField = value;
                    this.RaisePropertyChanged("Title");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="NewsImage", Namespace="http://schemas.datacontract.org/2004/07/DAL_Library")]
    [System.SerializableAttribute()]
    public partial class NewsImage : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ImageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WindowsService.ServiceRef.Image Image1Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WindowsService.ServiceRef.New NewField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int NewsField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Image {
            get {
                return this.ImageField;
            }
            set {
                if ((this.ImageField.Equals(value) != true)) {
                    this.ImageField = value;
                    this.RaisePropertyChanged("Image");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WindowsService.ServiceRef.Image Image1 {
            get {
                return this.Image1Field;
            }
            set {
                if ((object.ReferenceEquals(this.Image1Field, value) != true)) {
                    this.Image1Field = value;
                    this.RaisePropertyChanged("Image1");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WindowsService.ServiceRef.New New {
            get {
                return this.NewField;
            }
            set {
                if ((object.ReferenceEquals(this.NewField, value) != true)) {
                    this.NewField = value;
                    this.RaisePropertyChanged("New");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int News {
            get {
                return this.NewsField;
            }
            set {
                if ((this.NewsField.Equals(value) != true)) {
                    this.NewsField = value;
                    this.RaisePropertyChanged("News");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Image", Namespace="http://schemas.datacontract.org/2004/07/DAL_Library")]
    [System.SerializableAttribute()]
    public partial class Image : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WindowsService.ServiceRef.Binary Image1Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WindowsService.ServiceRef.NewsImage[] NewsImagesField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description {
            get {
                return this.DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
                    this.DescriptionField = value;
                    this.RaisePropertyChanged("Description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WindowsService.ServiceRef.Binary Image1 {
            get {
                return this.Image1Field;
            }
            set {
                if ((object.ReferenceEquals(this.Image1Field, value) != true)) {
                    this.Image1Field = value;
                    this.RaisePropertyChanged("Image1");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WindowsService.ServiceRef.NewsImage[] NewsImages {
            get {
                return this.NewsImagesField;
            }
            set {
                if ((object.ReferenceEquals(this.NewsImagesField, value) != true)) {
                    this.NewsImagesField = value;
                    this.RaisePropertyChanged("NewsImages");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Binary", Namespace="http://schemas.datacontract.org/2004/07/System.Data.Linq")]
    [System.SerializableAttribute()]
    public partial class Binary : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte[] BytesField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte[] Bytes {
            get {
                return this.BytesField;
            }
            set {
                if ((object.ReferenceEquals(this.BytesField, value) != true)) {
                    this.BytesField = value;
                    this.RaisePropertyChanged("Bytes");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceRef.INewsWCF")]
    public interface INewsWCF {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INewsWCF/createUser", ReplyAction="http://tempuri.org/INewsWCF/createUserResponse")]
        int createUser(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INewsWCF/createUser", ReplyAction="http://tempuri.org/INewsWCF/createUserResponse")]
        System.Threading.Tasks.Task<int> createUserAsync(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INewsWCF/connectUser", ReplyAction="http://tempuri.org/INewsWCF/connectUserResponse")]
        int connectUser(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INewsWCF/connectUser", ReplyAction="http://tempuri.org/INewsWCF/connectUserResponse")]
        System.Threading.Tasks.Task<int> connectUserAsync(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INewsWCF/getNews", ReplyAction="http://tempuri.org/INewsWCF/getNewsResponse")]
        WindowsService.ServiceRef.New[] getNews();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INewsWCF/getNews", ReplyAction="http://tempuri.org/INewsWCF/getNewsResponse")]
        System.Threading.Tasks.Task<WindowsService.ServiceRef.New[]> getNewsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INewsWCF/getHistoric", ReplyAction="http://tempuri.org/INewsWCF/getHistoricResponse")]
        WindowsService.ServiceRef.New[] getHistoric(int userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INewsWCF/getHistoric", ReplyAction="http://tempuri.org/INewsWCF/getHistoricResponse")]
        System.Threading.Tasks.Task<WindowsService.ServiceRef.New[]> getHistoricAsync(int userId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface INewsWCFChannel : WindowsService.ServiceRef.INewsWCF, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class NewsWCFClient : System.ServiceModel.ClientBase<WindowsService.ServiceRef.INewsWCF>, WindowsService.ServiceRef.INewsWCF {
        
        public NewsWCFClient() {
        }
        
        public NewsWCFClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public NewsWCFClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public NewsWCFClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public NewsWCFClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int createUser(string username, string password) {
            return base.Channel.createUser(username, password);
        }
        
        public System.Threading.Tasks.Task<int> createUserAsync(string username, string password) {
            return base.Channel.createUserAsync(username, password);
        }
        
        public int connectUser(string username, string password) {
            return base.Channel.connectUser(username, password);
        }
        
        public System.Threading.Tasks.Task<int> connectUserAsync(string username, string password) {
            return base.Channel.connectUserAsync(username, password);
        }
        
        public WindowsService.ServiceRef.New[] getNews() {
            return base.Channel.getNews();
        }
        
        public System.Threading.Tasks.Task<WindowsService.ServiceRef.New[]> getNewsAsync() {
            return base.Channel.getNewsAsync();
        }
        
        public WindowsService.ServiceRef.New[] getHistoric(int userId) {
            return base.Channel.getHistoric(userId);
        }
        
        public System.Threading.Tasks.Task<WindowsService.ServiceRef.New[]> getHistoricAsync(int userId) {
            return base.Channel.getHistoricAsync(userId);
        }
    }
}
