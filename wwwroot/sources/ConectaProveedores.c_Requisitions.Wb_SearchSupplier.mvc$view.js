import { withBaseWebBlock, textWidget as $text, getTranslation, ifWidget as $if, useTracing } from "@outsystems/runtime-view-js";
import { Form as OSWidgets$Form, Container as OSWidgets$Container, Label as OSWidgets$Label, Input as OSWidgets$Input, Button as OSWidgets$Button, Image as OSWidgets$Image } from "@outsystems/runtime-widgets-js";
import { Model as OS$Model, DataTypes as OS$DataTypes, Injector as OS$Injector, ServiceNames as OS$ServiceNames, BuiltinFunctions as OS$BuiltinFunctions, Navigation as OS$Navigation } from "@outsystems/runtime-core-js";
import ConectaProveedores_y_Utils_Wb_SearchSupplierDropdown_mvc_view from "./ConectaProveedores.y_Utils.Wb_SearchSupplierDropdown.mvc$view.js";
import { createElement } from "react";
import ConectaProveedores_c_Requisitions_Wb_SupplierType_mvc_view from "./ConectaProveedores.c_Requisitions.Wb_SupplierType.mvc$view.js";
import ModelFactory from "./ConectaProveedores.c_Requisitions.Wb_SearchSupplier.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.c_Requisitions.Wb_SearchSupplier.mvc$controller.js";

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
return createElement("div", props.rootNodeProperties, $if((model.variables.getSupplierByIdAggr.isDataFetchedAttr && (!(model.variables.getSupplierByIdAggr.hasFetchErrorAttr))), false, this, function () {
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
name: "Form"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(model.variables.isEnabledIn, false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "1"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(ConectaProveedores_y_Utils_Wb_SearchSupplierDropdown_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_SupplierId: model.variables.supplierIdIn,
_i_SupplierIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._supplierIdInDataFetchStatus),
i_RequisitionDetailRegionId: model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.regionIdAttr,
_i_RequisitionDetailRegionIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionByIdAggr.dataFetchStatusAttr),
i_IsDisable: false,
i_IsFilter: false,
i_IsMandatory: false,
i_IsValid: true
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
refresh$Action: function (supplierIdIn) {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.dropdownSuppliersOnChanged$Action(supplierIdIn, controller.callContext(eventHandlerContext));
});
;
}
},
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
_idProps: {
service: idService,
uuid: "2",
alias: "1"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel",
visible: true,
_idProps: {
service: idService,
uuid: "3"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
_idProps: {
service: idService,
uuid: "4"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("XtXygP04EEu8BSNJE1wdvw#Value", "Supplier"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
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
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel margin-top-m",
visible: true,
_idProps: {
service: idService,
uuid: "6"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
_idProps: {
service: idService,
uuid: "7"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("TKyIyzVXm0Sr8C0sRyJmcQ#Value", "Social Reason"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
enabled: false,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Text*/ 0,
mandatory: true,
maxLength: 500,
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("2ijh5iJHi02VeRbzJtB92g#ValueExpression.-1603192233.1", "Social Reason"),
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
uuid: "9"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
_idProps: {
service: idService,
uuid: "10"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("N5hE6I8FkECNmtUJFERqQg#Value", "RFC"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
enabled: false,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Text*/ 0,
mandatory: false,
maxLength: 50,
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("UZEelw3HVE6VkVYaqjXohw#ValueExpression.81039.1", "RFC"),
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
uuid: "12"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
_idProps: {
service: idService,
uuid: "13"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("FEjyy6fWyUSyFNn6DntsqA#Value", "Supplier Number"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
enabled: false,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Text*/ 0,
mandatory: true,
maxLength: 12,
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("RLZ3bPDABUy12GtHNW3LUw#ValueExpression.1930375325.1", "Supplier Number"),
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
uuid: "15"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
_idProps: {
service: idService,
uuid: "16"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("S1USLpZmEEC45yEmIfGxvg#Value", "Region"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
enabled: false,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Text*/ 0,
mandatory: false,
maxLength: 50,
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("NIznHK3gF0S_FIQGw6lUjQ#ValueExpression.-1850928364.1", "Region"),
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
uuid: "18"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
_idProps: {
service: idService,
uuid: "19"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("867xRYSNnUy9fdZSp_unMA#Value", "Group"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
enabled: false,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Text*/ 0,
mandatory: false,
maxLength: 50,
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("AFsML1_eK02qIAfTiPNr9Q#ValueExpression.69076575.1", "Group"),
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
uuid: "21"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
_idProps: {
service: idService,
uuid: "22"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("NsqpXnjw0U+rAovoFC7hcg#Value", "Line Of Business"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
enabled: false,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Text*/ 0,
mandatory: false,
maxLength: 50,
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("v_Y9nTE5XUS4qRqEpi+_uA#ValueExpression.2137166301.1", "Line Of Business"),
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
I_SupplierId: model.variables.supplierIdIn,
_i_SupplierIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._supplierIdInDataFetchStatus),
i_SupplierCountry: model.variables.getSupplierByIdAggr.listOut.getCurrent(callContext.iterationContext).supplierAttr.paisAttr,
_i_SupplierCountryInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getSupplierByIdAggr.dataFetchStatusAttr)
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
}
},
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
_idProps: {
service: idService,
uuid: "24",
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
uuid: "25"
},
_widgetRecordProvider: widgetsRecordProvider,
visible_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._isEnabledInDataFetchStatus)
}, createElement(OSWidgets$Button, {
enabled: model.getCachedValue(idService.getId("1PSxdOIsq0y6Ee1GIUKuqw.Enabled"), function () {
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
uuid: "26"
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
uuid: "27"
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
uuid: "28"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}), $text(getTranslation("Tay1grsryE+vL3TgRTTW2A#Value", "Use this supplier")))))];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "list-updating",
visible: true,
_idProps: {
service: idService,
uuid: "29"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "Wb_SearchSupplier",
functionKey: "75ca0d3c-4024-43cf-afb5-71417101b1aa",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "c_Requisitions.Wb_SearchSupplier",
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
return [ConectaProveedores_y_Utils_Wb_SearchSupplierDropdown_mvc_view, ConectaProveedores_c_Requisitions_Wb_SupplierType_mvc_view];
};


return ELEM;
};

export default componentFactory()
