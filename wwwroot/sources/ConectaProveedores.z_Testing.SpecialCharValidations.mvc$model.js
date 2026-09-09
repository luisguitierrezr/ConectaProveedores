import { Model as OS$Model, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";



class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("TextVar", "textVarVar", "TextVar", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false)
].concat(OS$DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static fromStructure(str) {
return new VariablesRecord(new VariablesRecord.RecordClass({
textVarVar: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

VariablesRecord.init();

class WidgetsRecord extends 
OS$Model.BaseWidgetRecordMap {
static getWidgetsType() {
return {
Input_TextVar: OS$Model.ValidationWidgetRecord
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


