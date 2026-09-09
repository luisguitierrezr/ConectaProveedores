import { withBaseWebBlock, textWidget as $text, getTranslation, Widget, asPrimitiveValue, ifWidget as $if, useTracing } from "@outsystems/runtime-view-js";
import { Container as OSWidgets$Container, Link as OSWidgets$Link, Image as OSWidgets$Image, Form as OSWidgets$Form, Label as OSWidgets$Label, Button as OSWidgets$Button } from "@outsystems/runtime-widgets-js";
import OutSystemsUI_Utilities_AlignCenter_mvc_view from "./OutSystemsUI.Utilities.AlignCenter.mvc$view.js";
import { createElement } from "react";
import { Navigation as OS$Navigation, DataConversion as OS$DataConversion, GenericTypeCache as OS$GenericTypeCache, BuiltinFunctions as OS$BuiltinFunctions, Model as OS$Model } from "@outsystems/runtime-core-js";
import { ST_60f22bd2e9b10a22278b8afe6d7f601aStructure } from "./OutSystemsUI.model.js";
import OutSystemsUI_Interaction_DropdownSearch_mvc_view from "./OutSystemsUI.Interaction.DropdownSearch.mvc$view.js";
import OutSystemsUI_Utilities_ButtonLoading_mvc_view from "./OutSystemsUI.Utilities.ButtonLoading.mvc$view.js";
import ModelFactory from "./ConectaProveedores.c_Requisitions.Wb_IsSpecialOrNormalWF_Popup.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.c_Requisitions.Wb_IsSpecialOrNormalWF_Popup.mvc$controller.js";

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
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "position-relative display font-size-main-heading",
visible: true,
_idProps: {
service: idService,
uuid: "1"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OutSystemsUI_Utilities_AlignCenter_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {},
events: {
_handleError: function (ex) {
controller.handleError(ex);
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "2",
alias: "1"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "text-align: left;"
},
gridProperties: {
classes: "ThemeGrid_Width11"
},
visible: true,
_idProps: {
service: idService,
uuid: "3"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("LqspVKackkK_rQjt1CSJhQ#Value", "Select special workflow"))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "text-align: right;"
},
gridProperties: {
classes: "ThemeGrid_Width1 ThemeGrid_MarginGutter"
},
visible: true,
_idProps: {
service: idService,
uuid: "4"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Link, {
enabled: (!(model.variables.l_IsBusyVar)),
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.close$Action(controller.callContext(eventHandlerContext));

;
},
style: "vertical-align",
visible: true,
_idProps: {
service: idService,
uuid: "5"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.times.svg"),
style: "img",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "6"
},
_widgetRecordProvider: widgetsRecordProvider
})))];
})
},
_dependencies: [asPrimitiveValue(model.variables.l_IsBusyVar)]
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-m",
visible: true,
_idProps: {
service: idService,
uuid: "7"
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
}, createElement(OSWidgets$Container, {
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
style: "mandatory",
_idProps: {
service: idService,
uuid: "10"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("SOiHRUkZMEq6YlxTZG9SVA#Value", "Approval Workflow"))), createElement(OutSystemsUI_Interaction_DropdownSearch_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
OptionsList: model.getCachedValue(idService.getId("zTsSZ0S_4E25cw7u+zYHbQ.OptionsList"), function () {
return OS$DataConversion.JSConversions.typeConvertRecordList(model.variables.getSpecialWorkflowsDataAct.approvalProcessListOut, new (OS$GenericTypeCache.getGenericList(ST_60f22bd2e9b10a22278b8afe6d7f601aStructure))(), function (source, target) {
target.valueAttr = OS$BuiltinFunctions.longIntegerToText(source.idAttr);
target.labelAttr = source.codeAttr;
target.descriptionAttr = source.descriptionAttr;
return target;
});
}, function () {
return model.variables.getSpecialWorkflowsDataAct.approvalProcessListOut;
}),
_optionsListInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getSpecialWorkflowsDataAct.dataFetchStatusAttr)
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
onChanged$Action: function (dropdownSearchIdIn, selectedOptionListIn) {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.dropdownSearchOnChangedWorkflow$Action(selectedOptionListIn, controller.callContext(eventHandlerContext));
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
uuid: "11",
alias: "2"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})), $if(model.variables.l_SpecialWorkflowSelectedVar.l_IsSelectFirstApproverAttr, false, this, function () {
return [$if(model.variables.getFirstApproverListDataAct.isDataFetchedAttr, false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel margin-top-m",
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
style: "mandatory",
_idProps: {
service: idService,
uuid: "13"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("syuKa_trYkeVXevTLc+MXA#Value", "First approver"))), createElement(OutSystemsUI_Interaction_DropdownSearch_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
OptionsList: model.getCachedValue(idService.getId("mYrTa4JqMkK1chSstkSCZg.OptionsList"), function () {
return OS$DataConversion.JSConversions.typeConvertRecordList(model.variables.getFirstApproverListDataAct.userListOut, new (OS$GenericTypeCache.getGenericList(ST_60f22bd2e9b10a22278b8afe6d7f601aStructure))(), function (source, target) {
target.valueAttr = source.userIdAttr;
target.labelAttr = source.userNameAttr;
target.descriptionAttr = source.roleNameAttr;
return target;
});
}, function () {
return model.variables.getFirstApproverListDataAct.userListOut;
}),
_optionsListInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFirstApproverListDataAct.dataFetchStatusAttr)
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
onChanged$Action: function (dropdownSearchIdIn, selectedOptionListIn) {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.dropdownSearchOnChangedFirstApprover$Action(selectedOptionListIn, controller.callContext(eventHandlerContext));

;
}
},
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
_idProps: {
service: idService,
uuid: "14",
alias: "3"
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
uuid: "15"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})];
}, function () {
return [];
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "text-align-right margin-top-m",
visible: true,
_idProps: {
service: idService,
uuid: "16"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Button, {
enabled: (!(model.variables.l_IsBusyVar)),
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
uuid: "17"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("waGdOGKPGE6ix1++8XB4Jg#Value", "Close"))), createElement(OSWidgets$Button, {
enabled: (!(model.variables.l_IsBusyVar)),
extendedProperties: {
style: "min-width: 100px; max-width: fit-content;"
},
gridProperties: {
classes: "ThemeGrid_MarginGutter"
},
isDefault: false,
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.selectWorkflow$Action(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()), OS$BuiltinFunctions.nullTextIdentifier(), controller.callContext(eventHandlerContext));

;
},
style: "btn ",
visible: true,
_idProps: {
service: idService,
uuid: "18"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("n8913Hce2EiDPWK7jc6+PQ#Value", "Hierarquical Flow"))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: true,
gridProperties: {
classes: "OSInline"
},
style: "margin-left-m",
visible: (model.variables.getSpecialWorkflowsDataAct.isDataFetchedAttr && (!(model.variables.getSpecialWorkflowsDataAct.approvalProcessListOut.isEmpty))),
_idProps: {
service: idService,
uuid: "19"
},
_widgetRecordProvider: widgetsRecordProvider,
visible_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getSpecialWorkflowsDataAct.dataFetchStatusAttr)
}, createElement(OutSystemsUI_Utilities_ButtonLoading_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
IsLoading: model.variables.l_IsBusyVar
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
uuid: "20",
alias: "4"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
button: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Button, {
enabled: (!(model.variables.l_IsBusyVar)),
isDefault: false,
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.confirmOnClick$Action(controller.callContext(eventHandlerContext));
});
;
},
style: "btn btn-primary",
visible: true,
_idProps: {
service: idService,
uuid: "21"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "osui-btn-loading__spinner-animation",
visible: true,
_idProps: {
service: idService,
uuid: "22"
},
_widgetRecordProvider: widgetsRecordProvider
}), $text(getTranslation("kNnPCyqJAEGbYvLAMzbU9g#Value", "Confirm")))];
})
},
_dependencies: [asPrimitiveValue(model.variables.l_IsBusyVar)]
})))))));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "Wb_IsSpecialOrNormalWF_Popup",
functionKey: "f7818724-9a72-403b-9e92-11669b31cec3",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "c_Requisitions.Wb_IsSpecialOrNormalWF_Popup",
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
return [OutSystemsUI_Utilities_AlignCenter_mvc_view, OutSystemsUI_Interaction_DropdownSearch_mvc_view, OutSystemsUI_Utilities_ButtonLoading_mvc_view];
};


return ELEM;
};

export default componentFactory()
