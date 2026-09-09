import { withBaseWebBlock, textWidget as $text, getTranslation, ifWidget as $if, Widget, asPrimitiveValue, useTracing } from "@outsystems/runtime-view-js";
import { Container as OSWidgets$Container, Form as OSWidgets$Form, Label as OSWidgets$Label, Text as OSWidgets$Text, List as OSWidgets$List, Checkbox as OSWidgets$Checkbox, Expression as OSWidgets$Expression, TextArea as OSWidgets$TextArea, Button as OSWidgets$Button } from "@outsystems/runtime-widgets-js";
import { createElement } from "react";
import { DataConversion as OS$DataConversion, GenericTypeCache as OS$GenericTypeCache, Model as OS$Model, BuiltinFunctions as OS$BuiltinFunctions, DataTypes as OS$DataTypes, Injector as OS$Injector, ServiceNames as OS$ServiceNames } from "@outsystems/runtime-core-js";
import { ST_60f22bd2e9b10a22278b8afe6d7f601aStructure } from "./OutSystemsUI.model.js";
import OutSystemsUI_Interaction_DropdownSearch_mvc_view from "./OutSystemsUI.Interaction.DropdownSearch.mvc$view.js";
import { SE_color as ConectaProveedores_staticEntities_color, SE_space as ConectaProveedores_staticEntities_space } from "./ConectaProveedores.staticEntities.js";
import OutSystemsUI_Utilities_Separator_mvc_view from "./OutSystemsUI.Utilities.Separator.mvc$view.js";
import OutSystemsUI_Utilities_AlignCenter_mvc_view from "./OutSystemsUI.Utilities.AlignCenter.mvc$view.js";
import ModelFactory from "./ConectaProveedores.a_Reassignments.Wb_ReassignmentForm.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.a_Reassignments.Wb_ReassignmentForm.mvc$controller.js";

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
visible: true,
_idProps: {
service: idService,
uuid: "0"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Form, {
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
}, $if(model.variables.getUsersSourceDataAct.isDataFetchedAttr, false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "2"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
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
}, $text(getTranslation("r8erJGxTxEytmV0qTH71OQ#Value", "Original User"))), createElement(OutSystemsUI_Interaction_DropdownSearch_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
OptionsList: model.getCachedValue(idService.getId("DD_SourceUser.OptionsList"), function () {
return OS$DataConversion.JSConversions.typeConvertRecordList(model.variables.getUsersSourceDataAct.o_DirectReportsListOut, new (OS$GenericTypeCache.getGenericList(ST_60f22bd2e9b10a22278b8afe6d7f601aStructure))(), function (source, target) {
target.valueAttr = source.entraIdAttr;
target.labelAttr = source.nameAttr;
target.groupNameAttr = source.roleAttr;
target.descriptionAttr = source.emailAttr;
return target;
});
}, function () {
return model.variables.getUsersSourceDataAct.o_DirectReportsListOut;
}),
_optionsListInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getUsersSourceDataAct.dataFetchStatusAttr)
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
onChanged$Action: function (dropdownSearchIdIn, selectedOptionListIn) {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.dD_SourceUserOnChanged$Action(selectedOptionListIn, controller.callContext(eventHandlerContext));
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
name: "DD_SourceUser",
alias: "1"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))), $if(((model.variables.l_SourceUserIdVar) !== (OS$BuiltinFunctions.nullTextIdentifier())), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "6"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(false, false, this, function () {
return [];
}, function () {
return [];
}), $if(model.variables.getSourceUserContentDataAct.isDataFetchedAttr, false, this, function () {
return [$if((model.variables.getSourceUserContentDataAct.reqListOut.isEmpty && model.variables.getSourceUserContentDataAct.invListOut.isEmpty), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-m text-align-center",
visible: true,
_idProps: {
service: idService,
uuid: "7"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("Qd1IExNkTUa6TueqZgWOpg#Value", "No content to be reassigned...")))];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-m",
visible: true,
_idProps: {
service: idService,
uuid: "8"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
name: "Requisitions"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
style: "text-neutral-7",
text: [$text(getTranslation("bOoMQV8a9kCXiaz9jEBUwQ#Value", "Requisitions"))],
_idProps: {
service: idService,
uuid: "10"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OutSystemsUI_Utilities_Separator_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
Color: ConectaProveedores_staticEntities_color.neutral6,
IsVertical: false,
Space: ConectaProveedores_staticEntities_space.small
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
uuid: "11",
alias: "2"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}), $if(model.variables.getSourceUserContentDataAct.reqListOut.isEmpty, false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "text-align-center",
visible: true,
_idProps: {
service: idService,
uuid: "12"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("6brdbA70o0WrOKlVZYW+SA#Value", "No requisitions to be reassigned...")))];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "13"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$List, {
animateItems: true,
gridProperties: {
classes: "OSFillParent"
},
mode: /*Default*/ 0,
source: model.variables.getSourceUserContentDataAct.reqListOut,
style: "list list-group",
tag: "div",
_idProps: {
service: idService,
uuid: "14"
},
_widgetRecordProvider: widgetsRecordProvider,
source_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getSourceUserContentDataAct.dataFetchStatusAttr),
placeholders: {
content: new Widget.IteratorPlaceholderContent(function (idService, callContext) {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "width: auto; "
},
gridProperties: {
classes: "OSInline"
},
style: "margin-bottom-s margin-left-base",
visible: true,
_idProps: {
service: idService,
uuid: "15"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getSourceUserContentDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getSourceUserContentDataAct.reqListOut.getCurrent(callContext.iterationContext).requisitionNameAttr), asPrimitiveValue(model.variables.getSourceUserContentDataAct.reqListOut.getCurrent(callContext.iterationContext).isSelectedAttr)]
}, createElement(OutSystemsUI_Utilities_AlignCenter_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
IsHorizontal: true
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
}
},
_validationProps: {
validationService: validationService,
validationParentId: idService.ownerService.getId("Form")
},
_idProps: {
service: idService,
uuid: "16",
alias: "3"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Checkbox, {
_validationProps: {
validationService: validationService,
validationParentId: idService.ownerService.getId("Form")
},
enabled: true,
onChange: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.checkbox_IsSelectedOnChange$Action(controller.callContext(eventHandlerContext));

;
},
style: "checkbox margin-right-xs",
variable: model.createVariable(OS$DataTypes.DataTypes.Boolean, model.variables.getSourceUserContentDataAct.reqListOut.getCurrent(callContext.iterationContext).isSelectedAttr, function (value) {
model.variables.getSourceUserContentDataAct.reqListOut.getCurrent(callContext.iterationContext).isSelectedAttr = value;
}),
_idProps: {
service: idService,
name: "Checkbox_IsSelected"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getSourceUserContentDataAct.dataFetchStatusAttr)
}), createElement(OSWidgets$Expression, {
gridProperties: {
classes: "ThemeGrid_MarginGutter"
},
value: model.variables.getSourceUserContentDataAct.reqListOut.getCurrent(callContext.iterationContext).requisitionNameAttr,
_idProps: {
service: idService,
uuid: "18"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getSourceUserContentDataAct.dataFetchStatusAttr)
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.getSourceUserContentDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getSourceUserContentDataAct.reqListOut.getCurrent(callContext.iterationContext).requisitionNameAttr), asPrimitiveValue(model.variables.getSourceUserContentDataAct.reqListOut.getCurrent(callContext.iterationContext).isSelectedAttr)]
}))];
}, callContext, idService, "1")
},
_dependencies: [asPrimitiveValue(model.variables.getSourceUserContentDataAct.dataFetchStatusAttr)]
}))];
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-base",
visible: true,
_idProps: {
service: idService,
name: "Invoices"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
style: "text-neutral-7",
text: [$text(getTranslation("EA01evwhjUiGc5fPRzP1kQ#Value", "Invoices"))],
_idProps: {
service: idService,
uuid: "20"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OutSystemsUI_Utilities_Separator_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
IsVertical: false,
Space: ConectaProveedores_staticEntities_space.small,
Color: ConectaProveedores_staticEntities_color.neutral6
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
uuid: "21",
alias: "4"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}), $if(model.variables.getSourceUserContentDataAct.invListOut.isEmpty, false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "text-align-center",
visible: true,
_idProps: {
service: idService,
uuid: "22"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("0kcBRUfCbU676wmrw930Sw#Value", "No invoices to be reassigned...")))];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "23"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$List, {
animateItems: true,
gridProperties: {
classes: "OSFillParent"
},
mode: /*Default*/ 0,
source: model.variables.getSourceUserContentDataAct.invListOut,
style: "list list-group",
tag: "div",
_idProps: {
service: idService,
uuid: "24"
},
_widgetRecordProvider: widgetsRecordProvider,
source_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getSourceUserContentDataAct.dataFetchStatusAttr),
placeholders: {
content: new Widget.IteratorPlaceholderContent(function (idService, callContext) {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "width: auto; "
},
gridProperties: {
classes: "OSInline"
},
style: "margin-bottom-s margin-left-base",
visible: true,
_idProps: {
service: idService,
uuid: "25"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getSourceUserContentDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getSourceUserContentDataAct.invListOut.getCurrent(callContext.iterationContext).invoiceNameAttr), asPrimitiveValue(model.variables.getSourceUserContentDataAct.invListOut.getCurrent(callContext.iterationContext).isSelectedAttr)]
}, createElement(OutSystemsUI_Utilities_AlignCenter_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
IsHorizontal: true
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
}
},
_validationProps: {
validationService: validationService,
validationParentId: idService.ownerService.getId("Form")
},
_idProps: {
service: idService,
uuid: "26",
alias: "5"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Checkbox, {
_validationProps: {
validationService: validationService,
validationParentId: idService.ownerService.getId("Form")
},
enabled: true,
onChange: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.checkbox_IsSelectedOnChange$Action(controller.callContext(eventHandlerContext));

;
},
style: "checkbox margin-right-xs",
variable: model.createVariable(OS$DataTypes.DataTypes.Boolean, model.variables.getSourceUserContentDataAct.invListOut.getCurrent(callContext.iterationContext).isSelectedAttr, function (value) {
model.variables.getSourceUserContentDataAct.invListOut.getCurrent(callContext.iterationContext).isSelectedAttr = value;
}),
_idProps: {
service: idService,
name: "Checkbox_IsSelected2"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getSourceUserContentDataAct.dataFetchStatusAttr)
}), createElement(OSWidgets$Expression, {
gridProperties: {
classes: "ThemeGrid_MarginGutter"
},
value: model.variables.getSourceUserContentDataAct.invListOut.getCurrent(callContext.iterationContext).invoiceNameAttr,
_idProps: {
service: idService,
uuid: "28"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getSourceUserContentDataAct.dataFetchStatusAttr)
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.getSourceUserContentDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getSourceUserContentDataAct.invListOut.getCurrent(callContext.iterationContext).invoiceNameAttr), asPrimitiveValue(model.variables.getSourceUserContentDataAct.invListOut.getCurrent(callContext.iterationContext).isSelectedAttr)]
}))];
}, callContext, idService, "2")
},
_dependencies: [asPrimitiveValue(model.variables.getSourceUserContentDataAct.dataFetchStatusAttr)]
}))];
}))), $if(model.variables.getUsersTargetDataAct.isDataFetchedAttr, false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel margin-top-m",
visible: true,
_idProps: {
service: idService,
uuid: "29"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
_idProps: {
service: idService,
uuid: "30"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("EjNKg2+NX0aiN0lMUsO7RA#Value", "Target User"))), createElement(OutSystemsUI_Interaction_DropdownSearch_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
OptionsList: model.getCachedValue(idService.getId("DD_TargetUserAU.OptionsList"), function () {
return OS$DataConversion.JSConversions.typeConvertRecordList(model.variables.getUsersTargetDataAct.o_UserTargetListAUOut, new (OS$GenericTypeCache.getGenericList(ST_60f22bd2e9b10a22278b8afe6d7f601aStructure))(), function (source, target) {
target.valueAttr = source.entraIdAttr;
target.labelAttr = source.nameAttr;
target.groupNameAttr = source.roleAttr;
target.descriptionAttr = source.emailAttr;
return target;
});
}, function () {
return model.variables.getUsersTargetDataAct.o_UserTargetListAUOut;
}),
_optionsListInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getUsersTargetDataAct.dataFetchStatusAttr)
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
onChanged$Action: function (dropdownSearchIdIn, selectedOptionListIn) {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.dD_TargetUserAUOnChanged$Action(selectedOptionListIn, controller.callContext(eventHandlerContext));

;
}
},
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
_idProps: {
service: idService,
name: "DD_TargetUserAU",
alias: "6"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "list-updating",
visible: true,
_idProps: {
service: idService,
uuid: "32"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})];
})];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "list-updating",
visible: true,
_idProps: {
service: idService,
uuid: "33"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}))];
}, function () {
return [$if(((model.variables.l_SourceUserEntraIdVar) !== ("")), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-m text-align-center",
visible: true,
_idProps: {
service: idService,
uuid: "34"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("k2ufMVUr0UWbXMSUVT_BOw#Value", "User has not  yet logged into the application.")))];
}, function () {
return [];
})];
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: true,
style: "os-boxlabel margin-top-m",
visible: model.getCachedValue(idService.getId("oq4_XFU8FEKBcD2EKk6kpg.Visible"), function () {
return (((model.variables.l_SourceUserIdVar) !== (OS$BuiltinFunctions.nullTextIdentifier())) && ((!(model.variables.getSourceUserContentDataAct.reqListOut.isEmpty)) || (!(model.variables.getSourceUserContentDataAct.invListOut.isEmpty))));
}, function () {
return model.variables.l_SourceUserIdVar;
}, function () {
return model.variables.getSourceUserContentDataAct.reqListOut.isEmpty;
}, function () {
return model.variables.getSourceUserContentDataAct.invListOut.isEmpty;
}),
_idProps: {
service: idService,
uuid: "35"
},
_widgetRecordProvider: widgetsRecordProvider,
visible_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getSourceUserContentDataAct.dataFetchStatusAttr)
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: true,
targetWidget: "TextArea_l_Reason",
_idProps: {
service: idService,
uuid: "36"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("dg2uYbYzw0etaT9tvCw3ww#Value", "Reason"))), createElement(OSWidgets$TextArea, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
enabled: true,
extendedProperties: {
style: "resize: none;"
},
gridProperties: {
classes: "OSFillParent"
},
mandatory: true,
maxLength: 2000,
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("ZAU_KNQGB0+d+AVdFtjtnA#ValueExpression.418463771.1", "Reason for reassignment..."),
style: "form-control",
textLines: 3,
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.l_ReasonVar, function (value) {
model.variables.l_ReasonVar = value;
}),
_idProps: {
service: idService,
name: "TextArea_l_Reason"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: true,
style: "margin-top-m text-align-right",
visible: model.getCachedValue(idService.getId("ntmv20NgIkyFZQITLVbGkQ.Visible"), function () {
return (((model.variables.l_SourceUserIdVar) !== (OS$BuiltinFunctions.nullTextIdentifier())) && ((!(model.variables.getSourceUserContentDataAct.reqListOut.isEmpty)) || (!(model.variables.getSourceUserContentDataAct.invListOut.isEmpty))));
}, function () {
return model.variables.l_SourceUserIdVar;
}, function () {
return model.variables.getSourceUserContentDataAct.reqListOut.isEmpty;
}, function () {
return model.variables.getSourceUserContentDataAct.invListOut.isEmpty;
}),
_idProps: {
service: idService,
uuid: "38"
},
_widgetRecordProvider: widgetsRecordProvider,
visible_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getSourceUserContentDataAct.dataFetchStatusAttr)
}, createElement(OSWidgets$Button, {
enabled: true,
extendedProperties: {
style: "min-width: 100px; max-width: fit-content;"
},
isDefault: false,
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.close$Action(controller.callContext(eventHandlerContext));

;
},
style: "btn btn-cancel",
visible: true,
_idProps: {
service: idService,
uuid: "39"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("ohE97+Oop0uTr1d5HoL+oQ#Value", "Close"))), createElement(OSWidgets$Button, {
enabled: model.getCachedValue(idService.getId("q0x9IWJL7E2PZd2anWhudQ.Enabled"), function () {
return ((model.variables.l_IsAllowConfirmVar && ((model.variables.l_TargetUserAUEntraIdVar) !== (""))) && ((OS$BuiltinFunctions.trim(model.variables.l_ReasonVar)) !== ("")));
}, function () {
return model.variables.l_IsAllowConfirmVar;
}, function () {
return model.variables.l_TargetUserAUEntraIdVar;
}, function () {
return model.variables.l_ReasonVar;
}),
extendedProperties: {
style: "border-width: 0px; min-width: 100px; max-width: fit-content;"
},
gridProperties: {
classes: "ThemeGrid_MarginGutter"
},
isDefault: false,
onClick: function () {
_this.validateWidget(idService.getId("Form"));
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.confirmOnClick$Action(controller.callContext(eventHandlerContext));
});

;
},
style: "btn btn-download btn-primary",
visible: true,
_idProps: {
service: idService,
uuid: "40"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("ueODr2julki21bPRSWukow#Value", "Confirm"))))];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "list-updating",
visible: true,
_idProps: {
service: idService,
uuid: "41"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}))));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "Wb_ReassignmentForm",
functionKey: "b96715b1-03c2-4d61-bebe-ee3858f065cb",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "a_Reassignments.Wb_ReassignmentForm",
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
return [OutSystemsUI_Interaction_DropdownSearch_mvc_view, OutSystemsUI_Utilities_Separator_mvc_view, OutSystemsUI_Utilities_AlignCenter_mvc_view];
};


return ELEM;
};

export default componentFactory()
