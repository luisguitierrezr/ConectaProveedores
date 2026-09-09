import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import ConectaProveedoresController$default from "./ConectaProveedores.controller.js";
import { Logger as OS$Logger, Exceptions as OS$Exceptions, Injector as OS$Injector, ServiceNames as OS$ServiceNames, ErrorHandling as OS$ErrorHandling, Controller as OS$Controller } from "@outsystems/runtime-core-js";
import ConectaProveedores_z_Hotfix_Controller_translationsResources from "./ConectaProveedores.z_Hotfix.controller$translationsResources.js";

class Controller extends 
OS$Controller.BaseController {
getDefaultTimeout() {
return ConectaProveedoresController$default.defaultTimeout;
}

get handleError() {if(!(this.hasOwnProperty("_handleError"))) {
this._handleError = function (ex, callContext) {
var controller = this.controller;
OS$Logger.debug("z_Hotfix", OS$Exceptions.getMessage(ex));
var globalExceptionHandle = OS$Injector.resolve(OS$ServiceNames.GlobalExceptionHandler);
globalExceptionHandle(ex, callContext);
return OS$ErrorHandling.UNHANDLED_ERROR_RESULT;


};
}

return this._handleError;
}set handleError(value) {this._handleError = value;
}

}



export default new Controller(ConectaProveedores_z_Hotfix_Controller_translationsResources);



