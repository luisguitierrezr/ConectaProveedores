import { Model as OS$Model, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import Telcel_Theme_Theme_Common_Menu_mvcModel from "./Telcel_Theme.Theme_Common.Menu.mvc$model.js";
import ConectaProveedores_a_Common_UserInfo_mvcModel from "./ConectaProveedores.a_Common.UserInfo.mvc$model.js";


class GetSettingsDataActRec extends 
OS$Model.DataSourceRecord {
static attributesToDeclare() {
return [
this.attr("o_IsDevEnvironment", "o_IsDevEnvironmentOut", "o_IsDevEnvironment", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("o_Environment", "o_EnvironmentOut", "o_Environment", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("o_IsActiveDEV_HU13045", "o_IsActiveDEV_HU13045Out", "o_IsActiveDEV_HU13045", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("o_IsActiveDEV_HU13046", "o_IsActiveDEV_HU13046Out", "o_IsActiveDEV_HU13046", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("o_IsActiveDEV_HU13047", "o_IsActiveDEV_HU13047Out", "o_IsActiveDEV_HU13047", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("o_IsActiveDEV_HU13048", "o_IsActiveDEV_HU13048Out", "o_IsActiveDEV_HU13048", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
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
}, true), 
this.attr("o_CanSeeDistributionError", "o_CanSeeDistributionErrorOut", "o_CanSeeDistributionError", true, false, OS$DataTypes.DataTypes.Boolean, function () {
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
this.attr("ActiveItem", "activeItemIn", "ActiveItem", true, false, OS$DataTypes.DataTypes.Integer, function () {
return (-1);
}, false), 
this.attr("_activeItemInDataFetchStatus", "_activeItemInDataFetchStatus", "_activeItemInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("ActiveSubItem", "activeSubItemIn", "ActiveSubItem", true, false, OS$DataTypes.DataTypes.Integer, function () {
return (-1);
}, false), 
this.attr("_activeSubItemInDataFetchStatus", "_activeSubItemInDataFetchStatus", "_activeSubItemInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
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
Model._hasValidationWidgetsValue = (Telcel_Theme_Theme_Common_Menu_mvcModel.hasValidationWidgets || ConectaProveedores_a_Common_UserInfo_mvcModel.hasValidationWidgets);
}

return Model._hasValidationWidgetsValue;
}
setInputs(inputs) {
if("ActiveItem" in inputs) {
this.variables.activeItemIn = inputs.ActiveItem;
if("_activeItemInDataFetchStatus" in inputs) {
this.variables._activeItemInDataFetchStatus = inputs._activeItemInDataFetchStatus;
}

}

if("ActiveSubItem" in inputs) {
this.variables.activeSubItemIn = inputs.ActiveSubItem;
if("_activeSubItemInDataFetchStatus" in inputs) {
this.variables._activeSubItemInDataFetchStatus = inputs._activeSubItemInDataFetchStatus;
}

}

}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS$Model.ModelFactory(Model);


