import {runPreInitialization, Injector, useBaseApplication, Format, useSettingsAndAuthConfigs, settingsUpdatedHandler, useVersionsManager, runPostInitialization, Interfaces, ErrorScreen} from "@outsystems/runtime-core-js";
import {default as ConectaProveedoresAppDefinition} from "./ConectaProveedores.appDefinition.js";
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
initType: Interfaces.Application.InitializationType.Minimal
}).then(function () {
function initView() {
ErrorScreen.renderErrorScreen(ConectaProveedoresAppDefinition);
}
return initView();

});
}).catch(function (error) {
console.error(error);
});

