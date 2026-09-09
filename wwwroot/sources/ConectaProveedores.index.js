import "./NullDebugger.js";
import {runPreInitialization, Injector, useBaseApplication, Format, useSettingsAndAuthConfigs, settingsUpdatedHandler, useVersionsManager, runPostInitialization, Interfaces, Application, Flow, ErrorHandling} from "@outsystems/runtime-core-js";
import {default as ConectaProveedoresAppDefinition} from "./ConectaProveedores.appDefinition.js";
import {Router} from "@outsystems/runtime-view-js";
import {ROUTER_INFO, SPLASH_SCREEN_ROUTE} from "./router_info.js";
runPreInitialization(Injector, {
applicationDefinition: ConectaProveedoresAppDefinition
}).then(function () {
return Promise.all([useBaseApplication(Injector, {
dateTimeFormat: new Format.DateTimeFormatInfo("yyyy-MM-dd", "HH:mm:ss"),
numberFormat: new Format.NumberFormatInfo(".", "")
}), useSettingsAndAuthConfigs(Injector, {
onSettingsUpdated: settingsUpdatedHandler
}), useVersionsManager()]);
}).then(function () {
return runPostInitialization({
initType: Interfaces.Application.InitializationType.Full
}).then(function (success) {
if(success) {
function initGlobalExceptionHandler() {
return new Promise(function (resolve) {
Promise.all([import("./ConectaProveedores.a_Common.controller.js")]).then(function (modules) {
var exceptionModule = modules[0];
Application.default.registerDefaultErrorHandler(function () {
return function (error, callContext) {
return exceptionModule.default.handleError(error, callContext);
};
});
resolve();
});
});
}
function initView() {
return new Promise(function (resolve, reject) {
try {Router.load(Application.default, {
staticScreenRoutes: ROUTER_INFO,
staticSplashRoute: SPLASH_SCREEN_ROUTE
});
resolve();
} catch (error) {
reject(error);
}

});
;
}
return initGlobalExceptionHandler().then(initView);

}

});
}).catch(function (error) {
ErrorHandling.handleError(error);
});

