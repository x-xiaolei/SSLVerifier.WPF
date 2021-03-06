﻿using System;
using System.Security;
using Newtonsoft.Json;
using SSLVerifier.Core;
using SysadminsLV.WPF.OfficeTheme.Toolkit.ViewModels;

namespace SSLVerifier.API.ModelObjects {
    public class ProxyObject : ViewModelBase, IServerProxy {
        Boolean useProxy, useAuth;
        String server, user;
        Int32 port = 8080;

        public Boolean UseProxy {
            get => useProxy;
            set {
                useProxy = value;
                OnPropertyChanged(nameof(UseProxy));
            }
        }
        public String Server {
            get => server;
            set {
                server = value;
                OnPropertyChanged(nameof(Server));
            }
        }
        public Int32 Port {
            get => port;
            set {
                port = value;
                OnPropertyChanged(nameof(Port));
            }
        }
        public Boolean UseAuthentication {
            get => useAuth;
            set {
                useAuth = value;
                OnPropertyChanged(nameof(UseAuthentication));
            }
        }
        public String UserName {
            get => user;
            set {
                user = value;
                OnPropertyChanged(nameof(UserName));
            }
        }
        [JsonIgnore]
        public SecureString SecurePassword { get; set; }
    }
}
