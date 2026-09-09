import { Model as OS$Model, GenericTypeCache as OS$GenericTypeCache, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import { EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord } from "./Organization.model.js";

class GetSupplierByIdAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList((OS$GenericTypeCache.getImplicitRecord(EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord, {
name: "Supplier",
attrName: "supplierAttr",
nameForJson: "Supplier",
uniqueId: "4934ec74-dc6a-8063-7b84-c0985f5b12ce"
}))));
}
static fromStructure(str) {
return new GetSupplierByIdAggrRec(new GetSupplierByIdAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetSupplierByIdAggrRec.init();



class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("l_IsOpenPopUp", "l_IsOpenPopUpVar", "l_IsOpenPopUp", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("GetSupplierById", "getSupplierByIdAggr", "GetSupplierById", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetSupplierByIdAggrRec());
}, true, GetSupplierByIdAggrRec)
].concat(OS$DataTypes.GenericRecord.attributesToDeclare.call(this));
}

}

VariablesRecord.init();

class WidgetsRecord extends 
OS$Model.BaseWidgetRecordMap {
static getWidgetsType() {
return {
ProfileDetailsForm: OS$Model.ValidationWidgetRecord,
Input_Number: OS$Model.ValidationWidgetRecord,
Input_Name: OS$Model.ValidationWidgetRecord,
Input_Email: OS$Model.ValidationWidgetRecord,
Input_RFC: OS$Model.ValidationWidgetRecord,
Input_Region: OS$Model.ValidationWidgetRecord,
Input_Group: OS$Model.ValidationWidgetRecord,
Input_LineOfBussiness: OS$Model.ValidationWidgetRecord
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
}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS$Model.ModelFactory(Model);


