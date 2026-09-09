import { Model as OS$Model, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import { ST_62dd5b695df6cdb1dddea5855e8718baStructure } from "./ConectaProveedores.model.js";
import OutSystemsUI_Utilities_Separator_mvcModel from "./OutSystemsUI.Utilities.Separator.mvc$model.js";



class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("FolioDetailInfo", "folioDetailInfoIn", "FolioDetailInfo", true, false, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new ST_62dd5b695df6cdb1dddea5855e8718baStructure());
}, false, ST_62dd5b695df6cdb1dddea5855e8718baStructure), 
this.attr("_folioDetailInfoInDataFetchStatus", "_folioDetailInfoInDataFetchStatus", "_folioDetailInfoInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
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
Model._hasValidationWidgetsValue = OutSystemsUI_Utilities_Separator_mvcModel.hasValidationWidgets;
}

return Model._hasValidationWidgetsValue;
}
setInputs(inputs) {
if("FolioDetailInfo" in inputs) {
this.variables.folioDetailInfoIn = inputs.FolioDetailInfo;
if("_folioDetailInfoInDataFetchStatus" in inputs) {
this.variables._folioDetailInfoInDataFetchStatus = inputs._folioDetailInfoInDataFetchStatus;
}

}

}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS$Model.ModelFactory(Model);


