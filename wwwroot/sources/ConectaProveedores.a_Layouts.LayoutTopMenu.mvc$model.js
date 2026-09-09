import { Model as OS$Model, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import Telcel_Theme_Theme_Layouts_Layout_Top_Menu_mvcModel from "./Telcel_Theme.Theme_Layouts.Layout_Top_Menu.mvc$model.js";
import ConectaProveedores_a_Common_Menu_mvcModel from "./ConectaProveedores.a_Common.Menu.mvc$model.js";
import ConectaProveedores_y_Utils_wb_LoadingLayer_mvcModel from "./ConectaProveedores.y_Utils.wb_LoadingLayer.mvc$model.js";
import Telcel_FloatingChatUILib_UIPatterns_FloatingChat_mvcModel from "./Telcel_FloatingChatUILib.UIPatterns.FloatingChat.mvc$model.js";
import ConectaProveedores_y_Utils_CopilotChat_mvcModel from "./ConectaProveedores.y_Utils.CopilotChat.mvc$model.js";



class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("HasFixedHeader", "hasFixedHeaderIn", "HasFixedHeader", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return true;
}, false), 
this.attr("_hasFixedHeaderInDataFetchStatus", "_hasFixedHeaderInDataFetchStatus", "_hasFixedHeaderInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("EnableAccessibilityFeatures", "enableAccessibilityFeaturesIn", "EnableAccessibilityFeatures", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("_enableAccessibilityFeaturesInDataFetchStatus", "_enableAccessibilityFeaturesInDataFetchStatus", "_enableAccessibilityFeaturesInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("ExtendedClass", "extendedClassIn", "ExtendedClass", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("_extendedClassInDataFetchStatus", "_extendedClassInDataFetchStatus", "_extendedClassInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("Initiative", "initiativeIn", "Initiative", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("_initiativeInDataFetchStatus", "_initiativeInDataFetchStatus", "_initiativeInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("ChatBotIsEnable", "chatBotIsEnableIn", "ChatBotIsEnable", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return true;
}, false), 
this.attr("_chatBotIsEnableInDataFetchStatus", "_chatBotIsEnableInDataFetchStatus", "_chatBotIsEnableInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false)
].concat(OS$DataTypes.GenericRecord.attributesToDeclare.call(this));
}

}

VariablesRecord.init();

class WidgetsRecord extends 
OS$Model.BaseWidgetRecordMap {
static getWidgetsType() {
return {};
}

}

class Model extends 
OS$Model.BaseViewModel {
static getVariablesRecordConstructor() {
return VariablesRecord;
}

static getWidgetsRecordConstructor() {
return WidgetsRecord;
}

static get hasValidationWidgets() {if((Model._hasValidationWidgetsValue === undefined)) {
Model._hasValidationWidgetsValue = ((((Telcel_Theme_Theme_Layouts_Layout_Top_Menu_mvcModel.hasValidationWidgets || ConectaProveedores_a_Common_Menu_mvcModel.hasValidationWidgets) || ConectaProveedores_y_Utils_wb_LoadingLayer_mvcModel.hasValidationWidgets) || Telcel_FloatingChatUILib_UIPatterns_FloatingChat_mvcModel.hasValidationWidgets) || ConectaProveedores_y_Utils_CopilotChat_mvcModel.hasValidationWidgets);
}

return Model._hasValidationWidgetsValue;
}
setInputs(inputs) {
if("HasFixedHeader" in inputs) {
this.variables.hasFixedHeaderIn = inputs.HasFixedHeader;
if("_hasFixedHeaderInDataFetchStatus" in inputs) {
this.variables._hasFixedHeaderInDataFetchStatus = inputs._hasFixedHeaderInDataFetchStatus;
}

}

if("EnableAccessibilityFeatures" in inputs) {
this.variables.enableAccessibilityFeaturesIn = inputs.EnableAccessibilityFeatures;
if("_enableAccessibilityFeaturesInDataFetchStatus" in inputs) {
this.variables._enableAccessibilityFeaturesInDataFetchStatus = inputs._enableAccessibilityFeaturesInDataFetchStatus;
}

}

if("ExtendedClass" in inputs) {
this.variables.extendedClassIn = inputs.ExtendedClass;
if("_extendedClassInDataFetchStatus" in inputs) {
this.variables._extendedClassInDataFetchStatus = inputs._extendedClassInDataFetchStatus;
}

}

if("Initiative" in inputs) {
this.variables.initiativeIn = inputs.Initiative;
if("_initiativeInDataFetchStatus" in inputs) {
this.variables._initiativeInDataFetchStatus = inputs._initiativeInDataFetchStatus;
}

}

if("ChatBotIsEnable" in inputs) {
this.variables.chatBotIsEnableIn = inputs.ChatBotIsEnable;
if("_chatBotIsEnableInDataFetchStatus" in inputs) {
this.variables._chatBotIsEnableInDataFetchStatus = inputs._chatBotIsEnableInDataFetchStatus;
}

}

}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS$Model.ModelFactory(Model);


