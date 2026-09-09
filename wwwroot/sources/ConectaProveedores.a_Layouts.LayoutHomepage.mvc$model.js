import { Model as OS$Model, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import Telcel_Theme_Theme_Layouts_Layout_Top_Menu_mvcModel from "./Telcel_Theme.Theme_Layouts.Layout_Top_Menu.mvc$model.js";
import Telcel_Theme_Theme_Common_HomepageMenu_mvcModel from "./Telcel_Theme.Theme_Common.HomepageMenu.mvc$model.js";
import ConectaProveedores_a_Common_UserInfo_mvcModel from "./ConectaProveedores.a_Common.UserInfo.mvc$model.js";
import ConectaProveedores_y_Utils_wb_LoadingLayer_mvcModel from "./ConectaProveedores.y_Utils.wb_LoadingLayer.mvc$model.js";


class GetSettingsDataActRec extends 
OS$Model.DataSourceRecord {
static attributesToDeclare() {
return [
this.attr("o_IsDevEnvironment", "o_IsDevEnvironmentOut", "o_IsDevEnvironment", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("o_Environment", "o_EnvironmentOut", "o_Environment", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS$Model.DataSourceRecord.attributesToDeclare.call(this));
}

}

GetSettingsDataActRec.init();

class GetUserDataDataActRec extends 
OS$Model.DataSourceRecord {
static attributesToDeclare() {
return [
this.attr("o_Region", "o_RegionOut", "o_Region", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("o_IsCXP", "o_IsCXPOut", "o_IsCXP", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, true)
].concat(OS$Model.DataSourceRecord.attributesToDeclare.call(this));
}

}

GetUserDataDataActRec.init();


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
this.attr("GetSettings", "getSettingsDataAct", "GetSettings", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetSettingsDataActRec());
}, true, GetSettingsDataActRec), 
this.attr("GetUserData", "getUserDataDataAct", "GetUserData", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetUserDataDataActRec());
}, true, GetUserDataDataActRec)
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
Model._hasValidationWidgetsValue = (((Telcel_Theme_Theme_Layouts_Layout_Top_Menu_mvcModel.hasValidationWidgets || Telcel_Theme_Theme_Common_HomepageMenu_mvcModel.hasValidationWidgets) || ConectaProveedores_a_Common_UserInfo_mvcModel.hasValidationWidgets) || ConectaProveedores_y_Utils_wb_LoadingLayer_mvcModel.hasValidationWidgets);
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

}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS$Model.ModelFactory(Model);


