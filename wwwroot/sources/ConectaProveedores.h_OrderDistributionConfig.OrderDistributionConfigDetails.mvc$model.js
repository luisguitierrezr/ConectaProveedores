import { Model as OS$Model, GenericTypeCache as OS$GenericTypeCache, DataTypes as OS$DataTypes, DataConversion } from "@outsystems/runtime-core-js";
import { EN_31f501c551d210017fcb34b5237e3390EntityRecord, EN_d466acc32a9bc0e97d052bc80d6c9d0bEntityRecord } from "./Organization.model.js";
import { EN_4ad0cdb13562998fda111463f2af9c31EntityRecord } from "./ConectaProveedores.model.js";

class GetRegionsAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList((OS$GenericTypeCache.getImplicitRecord(EN_31f501c551d210017fcb34b5237e3390EntityRecord, {
name: "Region",
attrName: "regionAttr",
nameForJson: "Region",
uniqueId: "deb85dc3-6640-fa92-8dae-5df2493065d0"
}))));
}
static fromStructure(str) {
return new GetRegionsAggrRec(new GetRegionsAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetRegionsAggrRec.init();

class GetOrderDistributionConfigByIdAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList((OS$GenericTypeCache.getImplicitRecord(EN_4ad0cdb13562998fda111463f2af9c31EntityRecord, {
name: "OrderDistributionConfig",
attrName: "orderDistributionConfigAttr",
nameForJson: "OrderDistributionConfig",
uniqueId: "9fc59bda-41db-740a-e87f-91f135d24811"
}))));
}
static fromStructure(str) {
return new GetOrderDistributionConfigByIdAggrRec(new GetOrderDistributionConfigByIdAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetOrderDistributionConfigByIdAggrRec.init();

class GetTelcelDirectionsAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList((OS$GenericTypeCache.getImplicitRecord(EN_d466acc32a9bc0e97d052bc80d6c9d0bEntityRecord, {
name: "TelcelDirection",
attrName: "telcelDirectionAttr",
nameForJson: "TelcelDirection",
uniqueId: "f7c59318-0743-40c0-e230-babd5ea62fb5"
}))));
}
static fromStructure(str) {
return new GetTelcelDirectionsAggrRec(new GetTelcelDirectionsAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetTelcelDirectionsAggrRec.init();



class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("ShowPopup", "showPopupVar", "ShowPopup", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("OriginalJSON", "originalJSONVar", "OriginalJSON", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("l_RefeshSideBar", "l_RefeshSideBarVar", "l_RefeshSideBar", true, false, OS$DataTypes.DataTypes.DateTime, function () {
return OS$DataTypes.DateTime.defaultValue;
}, false), 
this.attr("ConfigId", "configIdIn", "ConfigId", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("_configIdInDataFetchStatus", "_configIdInDataFetchStatus", "_configIdInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("GetRegions", "getRegionsAggr", "GetRegions", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetRegionsAggrRec());
}, true, GetRegionsAggrRec), 
this.attr("GetOrderDistributionConfigById", "getOrderDistributionConfigByIdAggr", "GetOrderDistributionConfigById", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetOrderDistributionConfigByIdAggrRec());
}, true, GetOrderDistributionConfigByIdAggrRec), 
this.attr("GetTelcelDirections", "getTelcelDirectionsAggr", "GetTelcelDirections", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetTelcelDirectionsAggrRec());
}, true, GetTelcelDirectionsAggrRec)
].concat(OS$DataTypes.GenericRecord.attributesToDeclare.call(this));
}

}

VariablesRecord.init();

class WidgetsRecord extends 
OS$Model.BaseWidgetRecordMap {
static getWidgetsType() {
return {
Form1: OS$Model.ValidationWidgetRecord,
Dropdown_Division: OS$Model.ValidationWidgetRecord,
Input_Applicant: OS$Model.ValidationWidgetRecord,
Input_ApplicantDescription: OS$Model.ValidationWidgetRecord,
Dropdown_Direction: OS$Model.ValidationWidgetRecord
};
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

static get hasValidationWidgets() {return true;
}
setInputs(inputs) {
if("ConfigId" in inputs) {
this.variables.configIdIn = DataConversion.ServerDataConverter.from(inputs.ConfigId, OS$DataTypes.DataTypes.LongInteger);
}

}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS$Model.ModelFactory(Model);


