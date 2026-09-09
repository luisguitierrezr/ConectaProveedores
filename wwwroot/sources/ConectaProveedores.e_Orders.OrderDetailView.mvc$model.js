import { Model as OS$Model, DataTypes as OS$DataTypes, DataConversion } from "@outsystems/runtime-core-js";
import ConectaProveedores_a_Layouts_CustomLayoutTopMenu_mvcModel from "./ConectaProveedores.a_Layouts.CustomLayoutTopMenu.mvc$model.js";
import ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_13008_mvcModel from "./ConectaProveedores.e_Orders.Wb_OrderDetailPaymentInformation_13008.mvc$model.js";
import ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_mvcModel from "./ConectaProveedores.e_Orders.Wb_OrderDetailPaymentInformation.mvc$model.js";


class GetSettingsDataActRec extends 
OS$Model.DataSourceRecord {
static attributesToDeclare() {
return [
this.attr("o_IsActiveDEV_HU13008_Complement", "o_IsActiveDEV_HU13008_ComplementOut", "o_IsActiveDEV_HU13008_Complement", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, true)
].concat(OS$Model.DataSourceRecord.attributesToDeclare.call(this));
}

static fromStructure(str) {
return new GetSettingsDataActRec(new GetSettingsDataActRec.RecordClass({
o_IsActiveDEV_HU13008_ComplementOut: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetSettingsDataActRec.init();


class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("i_OrderId", "i_OrderIdIn", "i_OrderId", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("_i_OrderIdInDataFetchStatus", "_i_OrderIdInDataFetchStatus", "_i_OrderIdInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("GetSettings", "getSettingsDataAct", "GetSettings", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetSettingsDataActRec());
}, true, GetSettingsDataActRec)
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
Model._hasValidationWidgetsValue = ((ConectaProveedores_a_Layouts_CustomLayoutTopMenu_mvcModel.hasValidationWidgets || ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_13008_mvcModel.hasValidationWidgets) || ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_mvcModel.hasValidationWidgets);
}

return Model._hasValidationWidgetsValue;
}
setInputs(inputs) {
if("i_OrderId" in inputs) {
this.variables.i_OrderIdIn = DataConversion.ServerDataConverter.from(inputs.i_OrderId, OS$DataTypes.DataTypes.LongInteger);
}

}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS$Model.ModelFactory(Model);


