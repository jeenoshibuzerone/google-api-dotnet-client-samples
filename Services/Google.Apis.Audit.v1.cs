//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.5466
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Google.Apis.Audit.v1.Data {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    
    
    public class Activities : Google.Apis.Requests.IDirectResponseSchema {
        
        private System.Collections.Generic.IList<Activity> _items;
        
        private string _kind;
        
        private string _next;
        
        private string _ETag;
        
        /// <summary>Each record in read response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<Activity> Items {
            get {
                return this._items;
            }
            set {
                this._items = value;
            }
        }
        
        /// <summary>Kind of list response this is.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind {
            get {
                return this._kind;
            }
            set {
                this._kind = value;
            }
        }
        
        /// <summary>Next page URL.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("next")]
        public virtual string Next {
            get {
                return this._next;
            }
            set {
                this._next = value;
            }
        }
        
        public virtual string ETag {
            get {
                return this._ETag;
            }
            set {
                this._ETag = value;
            }
        }
    }
    
    public class Activity {
        
        private Activity.ActorData _actor;
        
        private System.Collections.Generic.IList<Activity.EventsData> _events;
        
        private Activity.IdData _id;
        
        private string _ipAddress;
        
        private string _kind;
        
        private string _ownerDomain;
        
        /// <summary>User doing the action.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("actor")]
        public virtual Activity.ActorData Actor {
            get {
                return this._actor;
            }
            set {
                this._actor = value;
            }
        }
        
        /// <summary>Activity events.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("events")]
        public virtual System.Collections.Generic.IList<Activity.EventsData> Events {
            get {
                return this._events;
            }
            set {
                this._events = value;
            }
        }
        
        /// <summary>Unique identifier for each activity record.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual Activity.IdData Id {
            get {
                return this._id;
            }
            set {
                this._id = value;
            }
        }
        
        /// <summary>IP Address of the user doing the action.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ipAddress")]
        public virtual string IpAddress {
            get {
                return this._ipAddress;
            }
            set {
                this._ipAddress = value;
            }
        }
        
        /// <summary>Kind of resource this is.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind {
            get {
                return this._kind;
            }
            set {
                this._kind = value;
            }
        }
        
        /// <summary>Domain of source customer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ownerDomain")]
        public virtual string OwnerDomain {
            get {
                return this._ownerDomain;
            }
            set {
                this._ownerDomain = value;
            }
        }
        
        /// <summary>User doing the action.</summary>
        public class ActorData {
            
            private string _applicationId;
            
            private string _callerType;
            
            private string _email;
            
            private string _key;
            
            /// <summary>ID of application which interacted on behalf of the user.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("applicationId")]
            public virtual string ApplicationId {
                get {
                    return this._applicationId;
                }
                set {
                    this._applicationId = value;
                }
            }
            
            /// <summary>User or OAuth 2LO request.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("callerType")]
            public virtual string CallerType {
                get {
                    return this._callerType;
                }
                set {
                    this._callerType = value;
                }
            }
            
            /// <summary>Email address of the user.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("email")]
            public virtual string Email {
                get {
                    return this._email;
                }
                set {
                    this._email = value;
                }
            }
            
            /// <summary>For OAuth 2LO API requests, consumer_key of the requestor.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("key")]
            public virtual string Key {
                get {
                    return this._key;
                }
                set {
                    this._key = value;
                }
            }
        }
        
        public class EventsData {
            
            private string _eventType;
            
            private string _name;
            
            private System.Collections.Generic.IList<EventsData.ParametersData> _parameters;
            
            /// <summary>Type of event.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("eventType")]
            public virtual string EventType {
                get {
                    return this._eventType;
                }
                set {
                    this._eventType = value;
                }
            }
            
            /// <summary>Name of event.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("name")]
            public virtual string Name {
                get {
                    return this._name;
                }
                set {
                    this._name = value;
                }
            }
            
            /// <summary>Event parameters.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("parameters")]
            public virtual System.Collections.Generic.IList<EventsData.ParametersData> Parameters {
                get {
                    return this._parameters;
                }
                set {
                    this._parameters = value;
                }
            }
            
            public class ParametersData {
                
                private string _name;
                
                private string _value;
                
                /// <summary>Name of the parameter.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("name")]
                public virtual string Name {
                    get {
                        return this._name;
                    }
                    set {
                        this._name = value;
                    }
                }
                
                /// <summary>Value of the parameter.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("value")]
                public virtual string Value {
                    get {
                        return this._value;
                    }
                    set {
                        this._value = value;
                    }
                }
            }
        }
        
        /// <summary>Unique identifier for each activity record.</summary>
        public class IdData {
            
            private string _applicationId;
            
            private string _customerId;
            
            private string _time;
            
            private string _uniqQualifier;
            
            /// <summary>Application ID of the source application.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("applicationId")]
            public virtual string ApplicationId {
                get {
                    return this._applicationId;
                }
                set {
                    this._applicationId = value;
                }
            }
            
            /// <summary>Obfuscated customer ID of the source customer.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("customerId")]
            public virtual string CustomerId {
                get {
                    return this._customerId;
                }
                set {
                    this._customerId = value;
                }
            }
            
            /// <summary>Time of occurrence of the activity.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("time")]
            public virtual string Time {
                get {
                    return this._time;
                }
                set {
                    this._time = value;
                }
            }
            
            /// <summary>Unique qualifier if multiple events have the same time.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("uniqQualifier")]
            public virtual string UniqQualifier {
                get {
                    return this._uniqQualifier;
                }
                set {
                    this._uniqQualifier = value;
                }
            }
        }
    }
}
namespace Google.Apis.Audit.v1 {
    using System;
    using System.IO;
    using System.Collections.Generic;
    using Google.Apis;
    using Google.Apis.Discovery;
    
    
    public partial class AuditService : Google.Apis.Discovery.BaseClientService {
        
        public const string Version = "v1";
        
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;
        
        private System.Collections.Generic.IDictionary<string, Google.Apis.Discovery.IParameter> _serviceParameters;
        
        public AuditService(Google.Apis.Discovery.BaseClientService.Initializer initializer) : 
                base(initializer) {
            this._activities = new ActivitiesResource(this, Authenticator);
            this.InitParameters();
        }
        
        public AuditService() : 
                this(new Google.Apis.Discovery.BaseClientService.Initializer()) {
        }
        
        public override System.Collections.Generic.IList<string> Features {
            get {
                return new string[0];
            }
        }
        
        public override string Name {
            get {
                return "audit";
            }
        }
        
        public override string BaseUri {
            get {
                return "https://www.googleapis.com/apps/reporting/audit/v1/";
            }
        }
        
        public override System.Collections.Generic.IDictionary<string, Google.Apis.Discovery.IParameter> ServiceParameters {
            get {
                return this._serviceParameters;
            }
        }
        
        public override Google.Apis.Requests.IRequest CreateRequest(Google.Apis.Requests.IClientServiceRequest serviceRequest) {
            Google.Apis.Requests.IRequest request = Google.Apis.Requests.Request.CreateRequest(this, serviceRequest);
            if ((string.IsNullOrEmpty(ApiKey) == false)) {
                request = request.WithKey(this.ApiKey);
            }
            return request.WithAuthentication(Authenticator);
        }
        
        private void InitParameters() {
            System.Collections.Generic.Dictionary<string, Google.Apis.Discovery.IParameter> parameters = new System.Collections.Generic.Dictionary<string, Google.Apis.Discovery.IParameter>();
            parameters.Add("alt", Google.Apis.Util.Utilities.CreateRuntimeParameter("alt", false, "query", "json", null, new string[] {
                            "atom",
                            "json"}));
            parameters.Add("fields", Google.Apis.Util.Utilities.CreateRuntimeParameter("fields", false, "query", null, null, new string[0]));
            parameters.Add("key", Google.Apis.Util.Utilities.CreateRuntimeParameter("key", false, "query", null, null, new string[0]));
            parameters.Add("oauth_token", Google.Apis.Util.Utilities.CreateRuntimeParameter("oauth_token", false, "query", null, null, new string[0]));
            parameters.Add("prettyPrint", Google.Apis.Util.Utilities.CreateRuntimeParameter("prettyPrint", false, "query", "true", null, new string[0]));
            parameters.Add("quotaUser", Google.Apis.Util.Utilities.CreateRuntimeParameter("quotaUser", false, "query", null, null, new string[0]));
            parameters.Add("userIp", Google.Apis.Util.Utilities.CreateRuntimeParameter("userIp", false, "query", null, null, new string[0]));
            this._serviceParameters = new Google.Apis.Util.ReadOnlyDictionary<string, Google.Apis.Discovery.IParameter>(parameters);
        }
    }
    
    public class ActivitiesResource {
        
        private AuditService service;
        
        private Google.Apis.Authentication.IAuthenticator authenticator;
        
        private const string Resource = "activities";
        
        public ActivitiesResource(AuditService service, Google.Apis.Authentication.IAuthenticator authenticator) {
            this.service = service;
            this.authenticator = authenticator;
        }
        
        /// <summary>Retrieves a list of activities for a specific customer and application.</summary>
        /// <param name="customerId">Required - Must match pattern C.+ - Represents the customer who is the owner of target object on which action was performed.</param>
        /// <param name="applicationId">Required - Application ID of the application on which the event was performed.</param>
        public virtual ListRequest List(string customerId, string applicationId) {
            return new ListRequest(service, customerId, applicationId);
        }
        
        /// <summary>Type of the caller.</summary>
        [System.ComponentModel.TypeConverterAttribute(typeof(Google.Apis.Util.EnumStringValueTypeConverter))]
        public enum Caller {
            
            /// <summary>Caller is an application owner.</summary>
            [Google.Apis.Util.StringValueAttribute("application_owner")]
            Application_owner,
            
            /// <summary>Caller is a customer.</summary>
            [Google.Apis.Util.StringValueAttribute("customer")]
            Customer,
        }
        
        public class ListRequest : Google.Apis.Requests.ClientServiceRequest<Google.Apis.Audit.v1.Data.Activities> {
            
            private string _alt;
            
            private string _fields;
            
            private string _oauth_token;
            
            private System.Nullable<bool> _prettyPrint;
            
            private string _quotaUser;
            
            private string _userIp;
            
            private string _actorApplicationId;
            
            private string _actorEmail;
            
            private string _actorIpAddress;
            
            private string _applicationId;
            
            private System.Nullable<Caller> _caller;
            
            private string _continuationToken;
            
            private string _customerId;
            
            private string _endTime;
            
            private string _eventName;
            
            private System.Nullable<long> _maxResults;
            
            private string _startTime;
            
            public ListRequest(Google.Apis.Discovery.IClientService service, string customerId, string applicationId) : 
                    base(service) {
                this._customerId = customerId;
                this._applicationId = applicationId;
                this.InitParameters();
            }
            
            /// <summary>Data format for the response.</summary>
            [Google.Apis.Util.RequestParameterAttribute("alt", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Alt {
                get {
                    return this._alt;
                }
                set {
                    this._alt = value;
                }
            }
            
            /// <summary>Selector specifying which fields to include in a partial response.</summary>
            [Google.Apis.Util.RequestParameterAttribute("fields", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Fields {
                get {
                    return this._fields;
                }
                set {
                    this._fields = value;
                }
            }
            
            /// <summary>OAuth 2.0 token for the current user.</summary>
            [Google.Apis.Util.RequestParameterAttribute("oauth_token", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Oauth_token {
                get {
                    return this._oauth_token;
                }
                set {
                    this._oauth_token = value;
                }
            }
            
            /// <summary>Returns response with indentations and line breaks.</summary>
            [Google.Apis.Util.RequestParameterAttribute("prettyPrint", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> PrettyPrint {
                get {
                    return this._prettyPrint;
                }
                set {
                    this._prettyPrint = value;
                }
            }
            
            /// <summary>Available to use for quota purposes for server-side applications. Can be any arbitrary string assigned to a user, but should not exceed 40 characters. Overrides userIp if both are provided.</summary>
            [Google.Apis.Util.RequestParameterAttribute("quotaUser", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string QuotaUser {
                get {
                    return this._quotaUser;
                }
                set {
                    this._quotaUser = value;
                }
            }
            
            /// <summary>IP address of the site where the request originates. Use this if you want to enforce per-user limits.</summary>
            [Google.Apis.Util.RequestParameterAttribute("userIp", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string UserIp {
                get {
                    return this._userIp;
                }
                set {
                    this._userIp = value;
                }
            }
            
            /// <summary>Application ID of the application which interacted on behalf of the user while performing the event.</summary>
            [Google.Apis.Util.RequestParameterAttribute("actorApplicationId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string ActorApplicationId {
                get {
                    return this._actorApplicationId;
                }
                set {
                    this._actorApplicationId = value;
                }
            }
            
            /// <summary>Email address of the user who performed the action.</summary>
            [Google.Apis.Util.RequestParameterAttribute("actorEmail", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string ActorEmail {
                get {
                    return this._actorEmail;
                }
                set {
                    this._actorEmail = value;
                }
            }
            
            /// <summary>IP Address of host where the event was performed. Supports both IPv4 and IPv6 addresses.</summary>
            [Google.Apis.Util.RequestParameterAttribute("actorIpAddress", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string ActorIpAddress {
                get {
                    return this._actorIpAddress;
                }
                set {
                    this._actorIpAddress = value;
                }
            }
            
            /// <summary>Application ID of the application on which the event was performed.</summary>
            [Google.Apis.Util.RequestParameterAttribute("applicationId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ApplicationId {
                get {
                    return this._applicationId;
                }
            }
            
            /// <summary>Type of the caller.</summary>
            [Google.Apis.Util.RequestParameterAttribute("caller", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<Caller> Caller {
                get {
                    return this._caller;
                }
                set {
                    this._caller = value;
                }
            }
            
            /// <summary>Next page URL.</summary>
            [Google.Apis.Util.RequestParameterAttribute("continuationToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string ContinuationToken {
                get {
                    return this._continuationToken;
                }
                set {
                    this._continuationToken = value;
                }
            }
            
            /// <summary>Represents the customer who is the owner of target object on which action was performed.</summary>
            [Google.Apis.Util.RequestParameterAttribute("customerId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string CustomerId {
                get {
                    return this._customerId;
                }
            }
            
            /// <summary>Return events which occured at or before this time.</summary>
            [Google.Apis.Util.RequestParameterAttribute("endTime", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string EndTime {
                get {
                    return this._endTime;
                }
                set {
                    this._endTime = value;
                }
            }
            
            /// <summary>Name of the event being queried.</summary>
            [Google.Apis.Util.RequestParameterAttribute("eventName", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string EventName {
                get {
                    return this._eventName;
                }
                set {
                    this._eventName = value;
                }
            }
            
            /// <summary>Number of activity records to be shown in each page.</summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> MaxResults {
                get {
                    return this._maxResults;
                }
                set {
                    this._maxResults = value;
                }
            }
            
            /// <summary>Return events which occured at or after this time.</summary>
            [Google.Apis.Util.RequestParameterAttribute("startTime", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string StartTime {
                get {
                    return this._startTime;
                }
                set {
                    this._startTime = value;
                }
            }
            
            public override string ResourcePath {
                get {
                    return "activities";
                }
            }
            
            public override string MethodName {
                get {
                    return "list";
                }
            }
            
            public override string HttpMethod {
                get {
                    return "GET";
                }
            }
            
            public override string RestPath {
                get {
                    return "{customerId}/{applicationId}";
                }
            }
            
            private void InitParameters() {
                System.Collections.Generic.Dictionary<string, Google.Apis.Discovery.IParameter> parameters = new System.Collections.Generic.Dictionary<string, Google.Apis.Discovery.IParameter>();
                parameters.Add("actorApplicationId", Google.Apis.Util.Utilities.CreateRuntimeParameter("actorApplicationId", false, "query", null, null, new string[0]));
                parameters.Add("actorEmail", Google.Apis.Util.Utilities.CreateRuntimeParameter("actorEmail", false, "query", null, null, new string[0]));
                parameters.Add("actorIpAddress", Google.Apis.Util.Utilities.CreateRuntimeParameter("actorIpAddress", false, "query", null, null, new string[0]));
                parameters.Add("applicationId", Google.Apis.Util.Utilities.CreateRuntimeParameter("applicationId", true, "path", null, null, new string[0]));
                parameters.Add("caller", Google.Apis.Util.Utilities.CreateRuntimeParameter("caller", false, "query", null, null, new string[] {
                                "application_owner",
                                "customer"}));
                parameters.Add("continuationToken", Google.Apis.Util.Utilities.CreateRuntimeParameter("continuationToken", false, "query", null, null, new string[0]));
                parameters.Add("customerId", Google.Apis.Util.Utilities.CreateRuntimeParameter("customerId", true, "path", null, "C.+", new string[0]));
                parameters.Add("endTime", Google.Apis.Util.Utilities.CreateRuntimeParameter("endTime", false, "query", null, null, new string[0]));
                parameters.Add("eventName", Google.Apis.Util.Utilities.CreateRuntimeParameter("eventName", false, "query", null, null, new string[0]));
                parameters.Add("maxResults", Google.Apis.Util.Utilities.CreateRuntimeParameter("maxResults", false, "query", null, null, new string[0]));
                parameters.Add("startTime", Google.Apis.Util.Utilities.CreateRuntimeParameter("startTime", false, "query", null, null, new string[0]));
                this._requestParameters = new Google.Apis.Util.ReadOnlyDictionary<string, Google.Apis.Discovery.IParameter>(parameters);
            }
        }
    }
    
    public partial class AuditService {
        
        private const string Resource = "";
        
        private ActivitiesResource _activities;
        
        private Google.Apis.Discovery.IClientService service {
            get {
                return this;
            }
        }
        
        public virtual ActivitiesResource Activities {
            get {
                return this._activities;
            }
        }
    }
}
