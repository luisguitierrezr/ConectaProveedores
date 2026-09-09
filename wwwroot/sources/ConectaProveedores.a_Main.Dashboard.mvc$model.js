import { Model as OS$Model, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import ConectaProveedores_a_Main_DashboardAdmin_mvcModel from "./ConectaProveedores.a_Main.DashboardAdmin.mvc$model.js";
import ConectaProveedores_a_Main_DashboardTreasury_mvcModel from "./ConectaProveedores.a_Main.DashboardTreasury.mvc$model.js";
import ConectaProveedores_a_Main_DashboardApprover_mvcModel from "./ConectaProveedores.a_Main.DashboardApprover.mvc$model.js";
import ConectaProveedores_a_Main_DashboardProv_mvcModel from "./ConectaProveedores.a_Main.DashboardProv.mvc$model.js";
import ConectaProveedores_a_Main_DashboardReq_mvcModel from "./ConectaProveedores.a_Main.DashboardReq.mvc$model.js";



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
Model._hasValidationWidgetsValue = ((((ConectaProveedores_a_Main_DashboardAdmin_mvcModel.hasValidationWidgets || ConectaProveedores_a_Main_DashboardTreasury_mvcModel.hasValidationWidgets) || ConectaProveedores_a_Main_DashboardApprover_mvcModel.hasValidationWidgets) || ConectaProveedores_a_Main_DashboardProv_mvcModel.hasValidationWidgets) || ConectaProveedores_a_Main_DashboardReq_mvcModel.hasValidationWidgets);
}

return Model._hasValidationWidgetsValue;
}
setInputs(inputs) {
}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS$Model.ModelFactory(Model);


