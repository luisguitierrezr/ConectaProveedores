import { Model as OS$Model, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import ConectaProveedores_a_Common_WB_ExternalUserProfile_mvcModel from "./ConectaProveedores.a_Common.WB_ExternalUserProfile.mvc$model.js";
import ConectaProveedores_a_Common_WB_InternalUserProfile_mvcModel from "./ConectaProveedores.a_Common.WB_InternalUserProfile.mvc$model.js";



class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [].concat(OS$DataTypes.GenericRecord.attributesToDeclare.call(this));
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
OS$Model.VariablelessViewModel {
static getVariablesRecordConstructor() {
return VariablesRecord;
}

static getWidgetsRecordConstructor() {
return WidgetsRecord;
}

static get hasValidationWidgets() {if((Model._hasValidationWidgetsValue === undefined)) {
Model._hasValidationWidgetsValue = (ConectaProveedores_a_Common_WB_ExternalUserProfile_mvcModel.hasValidationWidgets || ConectaProveedores_a_Common_WB_InternalUserProfile_mvcModel.hasValidationWidgets);
}

return Model._hasValidationWidgetsValue;
}
setInputs(inputs) {
}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS$Model.ModelFactory(Model);


