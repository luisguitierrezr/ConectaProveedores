import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import ConectaProveedoresController$default from "./ConectaProveedores.controller.js";
import { Logger as OS$Logger, Exceptions as OS$Exceptions, Injector as OS$Injector, ServiceNames as OS$ServiceNames, ErrorHandling as OS$ErrorHandling, Controller as OS$Controller } from "@outsystems/runtime-core-js";
import ConectaProveedores_d_Invoices_FCP_Controller_translationsResources from "./ConectaProveedores.d_Invoices_FCP.controller$translationsResources.js";

class Controller extends 
OS$Controller.BaseController {
getDefaultTimeout() {
return ConectaProveedoresController$default.defaultTimeout;
}

get handleError() {if(!(this.hasOwnProperty("_handleError"))) {
this._handleError = function (ex, callContext) {
var controller = this.controller;
OS$Logger.debug("d_Invoices_FCP", OS$Exceptions.getMessage(ex));
var globalExceptionHandle = OS$Injector.resolve(OS$ServiceNames.GlobalExceptionHandler);
globalExceptionHandle(ex, callContext);
return OS$ErrorHandling.UNHANDLED_ERROR_RESULT;


};
}

return this._handleError;
}set handleError(value) {this._handleError = value;
}

}



export default new Controller(ConectaProveedores_d_Invoices_FCP_Controller_translationsResources);



