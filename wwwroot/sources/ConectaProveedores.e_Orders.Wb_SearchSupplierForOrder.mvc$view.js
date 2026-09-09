import { withBaseWebBlock, textWidget as $text, getTranslation, ifWidget as $if, useTracing } from "@outsystems/runtime-view-js";
import { Container as OSWidgets$Container, Form as OSWidgets$Form, Label as OSWidgets$Label, Input as OSWidgets$Input, Button as OSWidgets$Button, Image as OSWidgets$Image } from "@outsystems/runtime-widgets-js";
import { createElement } from "react";
import { Model as OS$Model, DataConversion as OS$DataConversion, GenericTypeCache as OS$GenericTypeCache, BuiltinFunctions as OS$BuiltinFunctions, Injector as OS$Injector, ServiceNames as OS$ServiceNames, DataTypes as OS$DataTypes, Navigation as OS$Navigation } from "@outsystems/runtime-core-js";
import { ST_60f22bd2e9b10a22278b8afe6d7f601aStructure } from "./OutSystemsUI.model.js";
import OutSystemsUI_Interaction_DropdownSearch_mvc_view from "./OutSystemsUI.Interaction.DropdownSearch.mvc$view.js";
import ConectaProveedores_c_Requisitions_Wb_SupplierType_mvc_view from "./ConectaProveedores.c_Requisitions.Wb_SupplierType.mvc$view.js";
import ModelFactory from "./ConectaProveedores.e_Orders.Wb_SearchSupplierForOrder.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.e_Orders.Wb_SearchSupplierForOrder.mvc$controller.js";

var componentFactory = function () {
var ELEM = withBaseWebBlock(function (props) {
var model = props.model;
var controller = props.controller;
var idService = props.controller.idService;
var validationService = controller.validationService;
var callContext = controller.callContext();
var _this = {
props: props,
validateWidget: function (widgetId) {
props.validateWidget(props, widgetId);
}
};
var widgetsRecordProvider = model;
var spanProvider = useTracing();
return createElement("div", props.rootNodeProperties, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "card",
visible: true,
_idProps: {
service: idService,
uuid: "0"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if((model.variables.getSupplierByIdAggr.isDataFetchedAttr && (!(model.variables.getSupplierByIdAggr.hasFetchErrorAttr))), false, this, function () {
return [createElement(OSWidgets$Form, {
_validationProps: {
validationService: validationService
},
gridProperties: {
classes: "OSFillParent"
},
style: "form",
_idProps: {
service: idService,
name: "Form1"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel",
visible: true,
_idProps: {
service: idService,
uuid: "2"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
_idProps: {
service: idService,
uuid: "3"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("G1jI_oC5AESmiXHH5FrBOQ#Value", "Supplier"))), $if(model.variables.isEnabledIn, false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "4"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OutSystemsUI_Interaction_DropdownSearch_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
OptionsList: model.getCachedValue(idService.getId("SuppierSearch.OptionsList"), function () {
return OS$DataConversion.JSConversions.typeConvertRecordList(model.variables.getSuppliersAggr.listOut, new (OS$GenericTypeCache.getGenericList(ST_60f22bd2e9b10a22278b8afe6d7f601aStructure))(), function (source, target) {
target.valueAttr = OS$BuiltinFunctions.longIntegerToText(source.supplierAttr.idAttr);
target.labelAttr = source.supplierAttr.nameAttr;
target.descriptionAttr = ((source.supplierAttr.numberAttr + " - ") + source.supplierAttr.n_ident_fis_1Attr);
return target;
});
}, function () {
return model.variables.getSuppliersAggr.listOut;
}),
_optionsListInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getSuppliersAggr.dataFetchStatusAttr),
StartingSelection: model.getCachedValue(idService.getId("SuppierSearch.StartingSelection"), function () {
return function () {
var list = new (OS$GenericTypeCache.getGenericList(ST_60f22bd2e9b10a22278b8afe6d7f601aStructure))();
list.pushAll([function () {
var rec = new ST_60f22bd2e9b10a22278b8afe6d7f601aStructure();
rec.valueAttr = OS$BuiltinFunctions.longIntegerToText(model.variables.getSupplierByIdAggr.listOut.getCurrent(callContext.iterationContext).supplierAttr.idAttr);
rec.labelAttr = model.variables.getSupplierByIdAggr.listOut.getCurrent(callContext.iterationContext).supplierAttr.nameAttr;
return rec;
}()]);
return list;
}();
}, function () {
return model.variables.getSupplierByIdAggr.listOut.getCurrent(callContext.iterationContext).supplierAttr.idAttr;
}, function () {
return model.variables.getSupplierByIdAggr.listOut.getCurrent(callContext.iterationContext).supplierAttr.nameAttr;
}),
_startingSelectionInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getSupplierByIdAggr.dataFetchStatusAttr),
Prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("VvKh_mWOhkSt+fEGrjwxJQ#Value.-1598661140.1", "Supplier")
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
onChanged$Action: function (dropdownSearchIdIn, selectedOptionListIn) {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.dropdownSearchOnChanged$Action(selectedOptionListIn, controller.callContext(eventHandlerContext));
});
;
}
},
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form1")
},
_idProps: {
service: idService,
name: "SuppierSearch",
alias: "1"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "6"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form1")
},
enabled: false,
extendedProperties: {
style: "margin-bottom: unset;"
},
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Text*/ 0,
mandatory: true,
maxLength: 500,
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.getSupplierByIdAggr.listOut.getCurrent(callContext.iterationContext).supplierAttr.nameAttr, function (value) {
model.variables.getSupplierByIdAggr.listOut.getCurrent(callContext.iterationContext).supplierAttr.nameAttr = value;
}),
_idProps: {
service: idService,
name: "Input_SupplierName"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getSupplierByIdAggr.dataFetchStatusAttr)
}))];
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel margin-top-m",
visible: true,
_idProps: {
service: idService,
uuid: "8"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
_idProps: {
service: idService,
uuid: "9"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("hefX1jXp3E2kjDzpliabKQ#Value", "Social Reason"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form1")
},
enabled: false,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Text*/ 0,
mandatory: true,
maxLength: 500,
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("yKHZhxRTRE6t+yA92jZx5A#ValueExpression.-1603192233.1", "Social Reason"),
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.getSupplierByIdAggr.listOut.getCurrent(callContext.iterationContext).supplierAttr.nameAttr, function (value) {
model.variables.getSupplierByIdAggr.listOut.getCurrent(callContext.iterationContext).supplierAttr.nameAttr = value;
}),
_idProps: {
service: idService,
name: "Input_SocialReason"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getSupplierByIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel",
visible: true,
_idProps: {
service: idService,
uuid: "11"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
_idProps: {
service: idService,
uuid: "12"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("6tPEq7IGr0iOMb4v9+RjvQ#Value", "RFC"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form1")
},
enabled: false,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Text*/ 0,
mandatory: false,
maxLength: 50,
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("YRNxpf5Kd0SeYCncAisOAQ#ValueExpression.81039.1", "RFC"),
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.getSupplierByIdAggr.listOut.getCurrent(callContext.iterationContext).supplierAttr.n_ident_fis_1Attr, function (value) {
model.variables.getSupplierByIdAggr.listOut.getCurrent(callContext.iterationContext).supplierAttr.n_ident_fis_1Attr = value;
}),
_idProps: {
service: idService,
name: "Input_RFC"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getSupplierByIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel",
visible: true,
_idProps: {
service: idService,
uuid: "14"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
_idProps: {
service: idService,
uuid: "15"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("E21IfKyJV02HJZKnGS1qlA#Value", "Supplier Number"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form1")
},
enabled: false,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Text*/ 0,
mandatory: true,
maxLength: 12,
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("4R1x_rbMxkOD0Ao9OJ3OWQ#ValueExpression.1930375325.1", "Supplier Number"),
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.getSupplierByIdAggr.listOut.getCurrent(callContext.iterationContext).supplierAttr.numberAttr, function (value) {
model.variables.getSupplierByIdAggr.listOut.getCurrent(callContext.iterationContext).supplierAttr.numberAttr = value;
}),
_idProps: {
service: idService,
name: "Input_SupplierNumber"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getSupplierByIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel",
visible: true,
_idProps: {
service: idService,
uuid: "17"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
_idProps: {
service: idService,
uuid: "18"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("QweslTSaBkeIcgNN8kO0pw#Value", "Region"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form1")
},
enabled: false,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Text*/ 0,
mandatory: false,
maxLength: 50,
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("KgfUfclJ0UWO7oTobPMpcg#ValueExpression.-1850928364.1", "Region"),
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.getSupplierByIdAggr.listOut.getCurrent(callContext.iterationContext).supplierAttr.region_Attr, function (value) {
model.variables.getSupplierByIdAggr.listOut.getCurrent(callContext.iterationContext).supplierAttr.region_Attr = value;
}),
_idProps: {
service: idService,
name: "Input_Region"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getSupplierByIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel",
visible: true,
_idProps: {
service: idService,
uuid: "20"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
_idProps: {
service: idService,
uuid: "21"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("7VEjxzJY6kuq4lOrkFDgDQ#Value", "Group"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form1")
},
enabled: false,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Text*/ 0,
mandatory: false,
maxLength: 50,
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("vN0QTh1bvESBsFxat0fBzg#ValueExpression.69076575.1", "Group"),
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.getSupplierByIdAggr.listOut.getCurrent(callContext.iterationContext).supplierAttr.grupodeporteAttr, function (value) {
model.variables.getSupplierByIdAggr.listOut.getCurrent(callContext.iterationContext).supplierAttr.grupodeporteAttr = value;
}),
_idProps: {
service: idService,
name: "Input_Group"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getSupplierByIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel",
visible: true,
_idProps: {
service: idService,
uuid: "23"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
_idProps: {
service: idService,
uuid: "24"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("VFgrYA96hEinmsZCeRZmJA#Value", "Line Of Business"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form1")
},
enabled: false,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Text*/ 0,
mandatory: false,
maxLength: 50,
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("7x0LmC1OeEupLI6x9AM4sg#ValueExpression.2137166301.1", "Line Of Business"),
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.getSupplierByIdAggr.listOut.getCurrent(callContext.iterationContext).supplierAttr.ramoAttr, function (value) {
model.variables.getSupplierByIdAggr.listOut.getCurrent(callContext.iterationContext).supplierAttr.ramoAttr = value;
}),
_idProps: {
service: idService,
name: "Input_LineOfBusiness"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getSupplierByIdAggr.dataFetchStatusAttr)
})), createElement(ConectaProveedores_c_Requisitions_Wb_SupplierType_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_SupplierCountry: model.variables.getSupplierByIdAggr.listOut.getCurrent(callContext.iterationContext).supplierAttr.paisAttr,
_i_SupplierCountryInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getSupplierByIdAggr.dataFetchStatusAttr),
I_SupplierId: model.variables.supplierIdIn,
_i_SupplierIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._supplierIdInDataFetchStatus)
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
}
},
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form1")
},
_idProps: {
service: idService,
uuid: "26",
alias: "2"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: true,
style: "os-boxlabel text-align-center margin-top-base",
visible: model.variables.isEnabledIn,
_idProps: {
service: idService,
uuid: "27"
},
_widgetRecordProvider: widgetsRecordProvider,
visible_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._isEnabledInDataFetchStatus)
}, createElement(OSWidgets$Button, {
enabled: model.getCachedValue(idService.getId("HoYTyFStQEWDFj2KfOODbg.Enabled"), function () {
return !(model.variables.supplierIdIn.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier())));
}, function () {
return model.variables.supplierIdIn;
}),
gridProperties: {
classes: "ThemeGrid_Width11",
marginLeft: "0"
},
isDefault: false,
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.useThisSupplierOnClick$Action(controller.callContext(eventHandlerContext));
});
;
},
style: "btn ",
visible: true,
_idProps: {
service: idService,
uuid: "28"
},
_widgetRecordProvider: widgetsRecordProvider,
enabled_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._supplierIdInDataFetchStatus)
}, $if(!(model.variables.supplierIdIn.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()))), false, this, function () {
return [createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Icon_backward2.svg"),
style: "margin-right-m",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "29"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}, function () {
return [createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Icon_backward_white.svg"),
style: "margin-right-m",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "30"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}), $text(getTranslation("8KMV15s9KUmhgvL6fgnqRQ#Value", "Use this supplier")))))];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "list-updating",
visible: true,
_idProps: {
service: idService,
uuid: "31"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "Wb_SearchSupplierForOrder",
functionKey: "24b2014c-74ed-4af8-bd45-b3bbfd8679de",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "e_Orders.Wb_SearchSupplierForOrder",
modelFactory: ModelFactory,
controllerFactory: ControllerFactory
});


ELEM.getCssDependencies = function () {
return ["css/OutSystemsReactWidgets.css"];
};


ELEM.getJsDependencies = function () {
return [];
};


ELEM.getBlocks = function () {
return [OutSystemsUI_Interaction_DropdownSearch_mvc_view, ConectaProveedores_c_Requisitions_Wb_SupplierType_mvc_view];
};


return ELEM;
};

export default componentFactory()
