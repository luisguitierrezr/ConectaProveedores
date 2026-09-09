using Microsoft.AspNetCore.Mvc;
using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Abstractions.Controllers;
using OutSystems.RESTService.Runtime.Abstractions.PropertyAttributes;
using OutSystems.RESTService.Runtime.Core;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;
using OutSystems.RESTService.Runtime.Core.ErrorHandling;
using OutSystems.RESTService.Runtime.Core.Filters;
using OutSystems.RESTService.Runtime.Core.ClientSettings;

namespace ssConectaProveedores.ScreenServices;

[TypeFilter(typeof(OnRequestFilter))]
[TypeFilter(typeof(OnResponseFilter))]
[Route("screenservices/ConectaProveedores/s_Storage/wb_DownloadFile")]
[RestServiceControllerConfiguration(DefaultValuesBehavior = DefaultValuesBehavior.Send, IsRESTRequest = false, HTTPSecurity = HTTPSecurity.SSL)]
public class ConectaProveedores_s_Storage_wb_DownloadFile_Controller : ScreenServicesApiController {

    public static ScreenControllerProxy ProxyInstance = new ScreenControllerProxy();
    public sealed class ScreenControllerProxy : ScreenServicesApiController.BaseScreenControllerProxy {
        public override CheckPermissionsIndex GetPermissionIndex() { return ConectaProveedores_s_Storage_wb_DownloadFile_Controller.Permissions; }
        public override IEnumerable<IScreenControllerProxy> GetChildControllers() { return ConectaProveedores_s_Storage_wb_DownloadFile_Controller.GetChildControllers(); }
        public override Type GetControllerType() { return typeof(ConectaProveedores_s_Storage_wb_DownloadFile_Controller); }
        public override void EnsureInitialized() { ConectaProveedores_s_Storage_wb_DownloadFile_Controller.EnsureInitialized(); }
        public override Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() { return ConectaProveedores_s_Storage_wb_DownloadFile_Controller.GetDbBinaryConfigs(); }
    }

    public static readonly CheckPermissionsIndex Permissions;

    private static readonly HashSet<IScreenControllerProxy> childControllers = new();
    public static IEnumerable<IScreenControllerProxy> GetChildControllers() {
        return childControllers;
    }

    private static volatile bool initialized = false;
    public static void EnsureInitialized() {
        // Only a single thread can do initializations at the time. Allows the CheckPermissionsIndex class non-threadsafe.
        // This should always be done only once at ApplicationStart
        lock (ScreenServicesApiController.GlobalScreenServicesInitializationLock) {
            if (!initialized) {
                initialized = true; // InitPermissionIndexes propagates to new parents as well so we can set it as initialized here before going into recursion

                SafeAddChildController(ConectaProveedores_Controller.ProxyInstance, childControllers);

                InitPermissionIndexes(Permissions, childControllers);
                
                
            }
        }
    }

    public static Dictionary<string, BinaryContentUtils.DbBinaryConfig> GetDbBinaryConfigs() {
        var dbBinaryConfigs = new Dictionary<string, BinaryContentUtils.DbBinaryConfig>();
        

        return dbBinaryConfigs;
    }



    static ConectaProveedores_s_Storage_wb_DownloadFile_Controller() {
        Permissions = new CheckPermissionsIndex();
        Permissions.AddPermissionPropagationPath(/* Any Usage */CheckPermissionsIndex.ANY_USAGE_KEY, new String[] { CheckPermissionsIndex.ANY_USAGE_KEY, 
/*s_Storage.wb_DownloadFile.ProcessNextFileChunk*/"6dONWMH_kUW9Ti9X5sMIKA*JssWAUZV4EWPnRWhkUq6Bg", 
/*s_Storage.wb_DownloadFile.EndProcess*/"6dONWMH_kUW9Ti9X5sMIKA*ODeWDfSKek6faooQyn4Bbw", 
/*SetClientTimeouts*/"6dONWMH_kUW9Ti9X5sMIKA*PRWPDzZzIk+W7U2j2Ny7PQ", 
/*s_Storage.wb_DownloadFile.OnChunkProcessed*/"6dONWMH_kUW9Ti9X5sMIKA*rjSqIEN9cE6r+df26X3c6w", 
/*s_Storage.wb_DownloadFile.FinalizeFileDownload*/"6dONWMH_kUW9Ti9X5sMIKA*4ChpTkWke0iDmtp8Zyyekw", 
/*s_Storage.wb_DownloadFile.StartFileDownload*/"6dONWMH_kUW9Ti9X5sMIKA*84_0eyxrHkmets90+9HoEw", 
/*GetFileChunk*/"6dONWMH_kUW9Ti9X5sMIKA*13jKyj2XnUCd+cBCoSv3SQ", 
/*s_Storage.wb_DownloadFile.StartProcess*/"6dONWMH_kUW9Ti9X5sMIKA*52GU1Hd84U+ClIAmakf3TA", 
/*s_Storage.wb_DownloadFile.OnChunkError*/"6dONWMH_kUW9Ti9X5sMIKA*7AoH3u4Hg0CATqTmjkWXjA"});

    }

    public ConectaProveedores_s_Storage_wb_DownloadFile_Controller(
        IAppInfo appInfo,
        IApplicationLogger applicationLogger,
        ISettingsProvider settingsProvider,
        IHttpContextAccessor httpContextAccessor,
        IRequestContext requestContext,
        IClientSettingsService clientSettingsService,
        IFileTokenSerializerConfigurator fileTokenSerializerConfigurator
    ) : base(
        appInfo,
        applicationLogger,
        settingsProvider,
        httpContextAccessor,
        requestContext,
        clientSettingsService,
        fileTokenSerializerConfigurator
    ) {
    }


}
