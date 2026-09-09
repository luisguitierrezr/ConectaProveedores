import { Model as OS$Model, DataTypes as OS$DataTypes, GenericTypeCache as OS$GenericTypeCache } from "@outsystems/runtime-core-js";
import { RC_df27c8a3fd58b3a0547b138755710019 } from "./ConectaProveedores.model.js";



class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("l_UnpayReason", "l_UnpayReasonVar", "l_UnpayReason", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("l_Filename", "l_FilenameVar", "l_Filename", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("l_BinaryData", "l_BinaryDataVar", "l_BinaryData", true, false, OS$DataTypes.DataTypes.BinaryData, function () {
return OS$DataTypes.BinaryData.defaultValue;
}, false), 
this.attr("l_DropdownReasonOptionsList", "l_DropdownReasonOptionsListVar", "l_DropdownReasonOptionsList", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(RC_df27c8a3fd58b3a0547b138755710019))());
}, false, (OS$GenericTypeCache.getGenericList(RC_df27c8a3fd58b3a0547b138755710019))), 
this.attr("l_DropdownReasonSelected", "l_DropdownReasonSelectedVar", "l_DropdownReasonSelected", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("i_ProposalLineIdToUnpayPayment", "i_ProposalLineIdToUnpayPaymentIn", "i_ProposalLineIdToUnpayPayment", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("_i_ProposalLineIdToUnpayPaymentInDataFetchStatus", "_i_ProposalLineIdToUnpayPaymentInDataFetchStatus", "_i_ProposalLineIdToUnpayPaymentInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false)
].concat(OS$DataTypes.GenericRecord.attributesToDeclare.call(this));
}

}

VariablesRecord.init();

class WidgetsRecord extends 
OS$Model.BaseWidgetRecordMap {
static getWidgetsType() {
return {
Dropdown_ReasonSelected: OS$Model.ValidationWidgetRecord,
TextArea_l_UnpayReason: OS$Model.ValidationWidgetRecord,
Upload: OS$Model.ValidationWidgetRecord,
Input_Filename: OS$Model.ValidationWidgetRecord
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
if("i_ProposalLineIdToUnpayPayment" in inputs) {
this.variables.i_ProposalLineIdToUnpayPaymentIn = inputs.i_ProposalLineIdToUnpayPayment;
if("_i_ProposalLineIdToUnpayPaymentInDataFetchStatus" in inputs) {
this.variables._i_ProposalLineIdToUnpayPaymentInDataFetchStatus = inputs._i_ProposalLineIdToUnpayPaymentInDataFetchStatus;
}

}

}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS$Model.ModelFactory(Model);


