import { withBaseWebBlock, textWidget as $text, getTranslation, Widget, ifWidget as $if, asPrimitiveValue, useTracing } from "@outsystems/runtime-view-js";
import { Container as OSWidgets$Container, List as OSWidgets$List, Expression as OSWidgets$Expression, Image as OSWidgets$Image, Icon as OSWidgets$Icon } from "@outsystems/runtime-widgets-js";
import { createElement } from "react";
import OutSystemsUI_Navigation_DEPRECATED_WizardV2_mvc_view from "./OutSystemsUI.Navigation.DEPRECATED_WizardV2.mvc$view.js";
import { SE_approvalStatus as ConectaProveedores_staticEntities_approvalStatus, SE_steps as ConectaProveedores_staticEntities_steps, SE_trigger as ConectaProveedores_staticEntities_trigger, SE_position as ConectaProveedores_staticEntities_position } from "./ConectaProveedores.staticEntities.js";
import OutSystemsUI_Navigation_DEPRECATED_WizardItemV2_mvc_view from "./OutSystemsUI.Navigation.DEPRECATED_WizardItemV2.mvc$view.js";
import OutSystemsUI_Utilities_AlignCenter_mvc_view from "./OutSystemsUI.Utilities.AlignCenter.mvc$view.js";
import OutSystemsUI_Content_Tooltip_mvc_view from "./OutSystemsUI.Content.Tooltip.mvc$view.js";
import { Navigation as OS$Navigation } from "@outsystems/runtime-core-js";
import Telcel_Theme_Utils_Wb_ShortText_mvc_view from "./Telcel_Theme.Utils.Wb_ShortText.mvc$view.js";
import ModelFactory from "./ConectaProveedores.y_Utils.Wb_FolioEntra_Historic.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.y_Utils.Wb_FolioEntra_Historic.mvc$controller.js";

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
extendedProperties: {
style: "font-size: 24px;"
},
style: "display margin-top-base",
visible: true,
_idProps: {
service: idService,
uuid: "0"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("O4ie3cXfPEe2XXnbRTsWEA#Value", "Approval"))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: " "
},
style: "card margin-top-m font-semi-bold",
visible: true,
_idProps: {
service: idService,
name: "Historic_ApprovalFlow"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if((model.variables.getOrderMainApprovalLevelsAggr.isDataFetchedAttr && model.variables.getEntraUserManagerListDataAct.isDataFetchedAttr), false, this, function () {
return [createElement(OutSystemsUI_Navigation_DEPRECATED_WizardV2_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
IsVertical: true
},
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
return [createElement(OSWidgets$List, {
animateItems: true,
gridProperties: {
classes: "OSFillParent"
},
mode: /*Default*/ 0,
source: model.variables.listVar,
style: "list list-group",
tag: "div",
_idProps: {
service: idService,
uuid: "3"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.IteratorPlaceholderContent(function (idService, callContext) {
return [createElement(OutSystemsUI_Navigation_DEPRECATED_WizardItemV2_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
Status: model.getCachedValue(idService.getId("6Uu4aCjbk0GO0bONaik0gQ.Status"), function () {
return (((model.variables.listVar.getCurrent(callContext.iterationContext).approvalStatusIdAttr === ConectaProveedores_staticEntities_approvalStatus.pending)) ? (ConectaProveedores_staticEntities_steps.next) : (((((model.variables.listVar.getCurrent(callContext.iterationContext).approvalStatusIdAttr) !== (ConectaProveedores_staticEntities_approvalStatus.notApproved))) ? (ConectaProveedores_staticEntities_steps.past) : (ConectaProveedores_staticEntities_steps.active))));
}, function () {
return model.variables.listVar.getCurrent(callContext.iterationContext).approvalStatusIdAttr;
})
},
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
uuid: "4",
alias: "2"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
icon: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Expression, {
value: ((model.variables.listVar.getCurrentRowNumber(callContext.iterationContext) + 1)).toString(),
_idProps: {
service: idService,
uuid: "5"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}),
label: new Widget.PlaceholderContent(function () {
return [$if(((model.variables.listVar.getCurrent(callContext.iterationContext).approvalStatusIdAttr) !== (ConectaProveedores_staticEntities_approvalStatus.pending)), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "6"
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
uuid: "7",
alias: "3"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width9"
},
style: "align-column-vertically",
visible: true,
_idProps: {
service: idService,
uuid: "8"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
extendedProperties: {
title: model.variables.listVar.getCurrent(callContext.iterationContext).roleAttr
},
style: "text-align-left text-primary white-space-nowrap",
value: model.variables.listVar.getCurrent(callContext.iterationContext).roleAttr,
_idProps: {
service: idService,
uuid: "9"
},
_widgetRecordProvider: widgetsRecordProvider
}), $if(model.variables.listVar.getCurrent(callContext.iterationContext).isReassignedAttr, false, this, function () {
return [createElement(OutSystemsUI_Content_Tooltip_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
Trigger: ConectaProveedores_staticEntities_trigger.onHover,
Position: ConectaProveedores_staticEntities_position.top
},
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
uuid: "10",
alias: "4"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Icon_recargar2.svg"),
style: "img",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "11"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}),
tooltip: new Widget.PlaceholderContent(function () {
return [$text(getTranslation("3UOarxKo+0+V+inBPZAFhA#Value", "Through reassignment"))];
})
},
_dependencies: []
})];
}, function () {
return [];
}), $if(model.variables.listVar.getCurrent(callContext.iterationContext).approveAsAreaUsuariaAttr, false, this, function () {
return [createElement(OutSystemsUI_Content_Tooltip_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
Trigger: ConectaProveedores_staticEntities_trigger.onHover,
Position: ConectaProveedores_staticEntities_position.top
},
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
uuid: "12",
alias: "5"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Icon_info.svg"),
style: "img",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "13"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}),
tooltip: new Widget.PlaceholderContent(function () {
return [$text(getTranslation("dj5Rx1yO+UWMqZnpNAiVzA#Value", "Without Contract or Proof Of Foreign Residence"))];
})
},
_dependencies: []
})];
}, function () {
return [];
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "height: 24px;"
},
gridProperties: {
classes: "ThemeGrid_Width3 ThemeGrid_MarginGutter"
},
style: "text-align-right",
visible: true,
_idProps: {
service: idService,
uuid: "14"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if((model.variables.listVar.getCurrent(callContext.iterationContext).approvalStatusIdAttr === ConectaProveedores_staticEntities_approvalStatus.canceled), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "align-column-vertically margin-right-xs",
visible: true,
_idProps: {
service: idService,
uuid: "15"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OutSystemsUI_Content_Tooltip_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
Position: ConectaProveedores_staticEntities_position.topLeft,
StartsOpen: true,
Trigger: ConectaProveedores_staticEntities_trigger.onHover
},
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
uuid: "16",
alias: "6"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Icon_chat.svg"),
style: "img",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "17"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}),
tooltip: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Expression, {
value: model.variables.listVar.getCurrent(callContext.iterationContext).cancelMessageAttr,
_idProps: {
service: idService,
uuid: "18"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.listVar.getCurrent(callContext.iterationContext).cancelMessageAttr)]
}), createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.RedEncerrar.svg"),
style: "img",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "19"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
}, function () {
return [$if((model.variables.listVar.getCurrent(callContext.iterationContext).approvalStatusIdAttr === ConectaProveedores_staticEntities_approvalStatus.approved), false, this, function () {
return [createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Icon_hecho_lleno.svg"),
style: "img",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "20"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}, function () {
return [$if((model.variables.listVar.getCurrent(callContext.iterationContext).approvalStatusIdAttr === ConectaProveedores_staticEntities_approvalStatus.modify), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "align-column-vertically",
visible: true,
_idProps: {
service: idService,
uuid: "21"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OutSystemsUI_Content_Tooltip_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
Trigger: ConectaProveedores_staticEntities_trigger.onHover,
Position: ConectaProveedores_staticEntities_position.topLeft
},
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
uuid: "22",
alias: "7"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Icon_chat.svg"),
style: "img",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "23"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}),
tooltip: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Expression, {
value: model.variables.listVar.getCurrent(callContext.iterationContext).modifyMessageAttr,
_idProps: {
service: idService,
uuid: "24"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.listVar.getCurrent(callContext.iterationContext).modifyMessageAttr)]
}), createElement(OSWidgets$Icon, {
extendedProperties: {
style: "font-size: 24px; color: #ff9100;"
},
gridProperties: {
classes: "ThemeGrid_MarginGutter"
},
icon: "wrench",
iconSize: /*FontSize*/ 0,
style: "icon",
visible: true,
_idProps: {
service: idService,
uuid: "25"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
}, function () {
return [];
})];
})];
}))];
})
},
_dependencies: [asPrimitiveValue(model.variables.listVar.getCurrent(callContext.iterationContext).modifyMessageAttr), asPrimitiveValue(model.variables.listVar.getCurrent(callContext.iterationContext).cancelMessageAttr), asPrimitiveValue(model.variables.listVar.getCurrent(callContext.iterationContext).approvalStatusIdAttr), asPrimitiveValue(model.variables.listVar.getCurrent(callContext.iterationContext).approveAsAreaUsuariaAttr), asPrimitiveValue(model.variables.listVar.getCurrent(callContext.iterationContext).isReassignedAttr), asPrimitiveValue(model.variables.listVar.getCurrent(callContext.iterationContext).roleAttr)]
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: true,
style: "text-align-left font-regular italic font-size-xs",
visible: ((model.variables.listVar.getCurrent(callContext.iterationContext).nameAttr) !== ("")),
_idProps: {
service: idService,
uuid: "26"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.variables.listVar.getCurrent(callContext.iterationContext).nameAttr,
_idProps: {
service: idService,
uuid: "27"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "28"
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
uuid: "29",
alias: "8"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "align-column-vertically",
visible: true,
_idProps: {
service: idService,
uuid: "30"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(model.variables.listVar.getCurrent(callContext.iterationContext).isNotMappedAttr, false, this, function () {
return [createElement(OutSystemsUI_Content_Tooltip_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
Position: ConectaProveedores_staticEntities_position.left,
Trigger: ConectaProveedores_staticEntities_trigger.onHover
},
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
uuid: "31",
alias: "9"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Icon, {
extendedProperties: {
style: "color: #ff8400;"
},
icon: "exclamation-triangle",
iconSize: /*FontSize*/ 0,
style: "icon",
visible: true,
_idProps: {
service: idService,
uuid: "32"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}),
tooltip: new Widget.PlaceholderContent(function () {
return [$text(getTranslation("nLcISiAVa0Swb89Q0Ku5iQ#Value", "Role not yet mapped to an application role."))];
})
},
_dependencies: []
})];
}, function () {
return [];
}), createElement(Telcel_Theme_Utils_Wb_ShortText_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_Text: model.variables.listVar.getCurrent(callContext.iterationContext).roleAttr,
i_NChar: 20
},
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
uuid: "33",
alias: "10"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}), $if(model.variables.listVar.getCurrent(callContext.iterationContext).approveAsAreaUsuariaAttr, false, this, function () {
return [createElement(OutSystemsUI_Content_Tooltip_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
Position: ConectaProveedores_staticEntities_position.top,
Trigger: ConectaProveedores_staticEntities_trigger.onHover
},
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
uuid: "34",
alias: "11"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Icon_info.svg"),
style: "img",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "35"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}),
tooltip: new Widget.PlaceholderContent(function () {
return [$text(getTranslation("ExILpCdSCUWV7fIx7FXQPA#Value", "Without Contract or Proof Of Foreign Residence"))];
})
},
_dependencies: []
})];
}, function () {
return [];
}))];
})
},
_dependencies: [asPrimitiveValue(model.variables.listVar.getCurrent(callContext.iterationContext).approveAsAreaUsuariaAttr), asPrimitiveValue(model.variables.listVar.getCurrent(callContext.iterationContext).roleAttr), asPrimitiveValue(model.variables.listVar.getCurrent(callContext.iterationContext).isNotMappedAttr)]
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: true,
style: "text-align-left font-regular italic font-size-xs margin-top-s",
visible: ((model.variables.listVar.getCurrent(callContext.iterationContext).nameAttr) !== ("")),
_idProps: {
service: idService,
uuid: "36"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.variables.listVar.getCurrent(callContext.iterationContext).nameAttr,
_idProps: {
service: idService,
uuid: "37"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.listVar.getCurrent(callContext.iterationContext).isNotMappedAttr), asPrimitiveValue(model.variables.listVar.getCurrent(callContext.iterationContext).nameAttr), asPrimitiveValue(model.variables.listVar.getCurrent(callContext.iterationContext).modifyMessageAttr), asPrimitiveValue(model.variables.listVar.getCurrent(callContext.iterationContext).cancelMessageAttr), asPrimitiveValue(model.variables.listVar.getCurrent(callContext.iterationContext).approveAsAreaUsuariaAttr), asPrimitiveValue(model.variables.listVar.getCurrent(callContext.iterationContext).isReassignedAttr), asPrimitiveValue(model.variables.listVar.getCurrent(callContext.iterationContext).roleAttr), asPrimitiveValue(model.variables.listVar.getCurrent(callContext.iterationContext).approvalStatusIdAttr), asPrimitiveValue(model.variables.listVar.getCurrentRowNumber(callContext.iterationContext))]
})];
}, callContext, idService, "1")
},
_dependencies: []
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.listVar)]
}), $if(false, false, this, function () {
return [];
}, function () {
return [];
})];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "list-updating",
visible: true,
_idProps: {
service: idService,
uuid: "38"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "Wb_FolioEntra_Historic",
functionKey: "5b938353-a19d-4b13-8382-9ffa815b6baa",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "y_Utils.Wb_FolioEntra_Historic",
modelFactory: ModelFactory,
controllerFactory: ControllerFactory
});


ELEM.getCssDependencies = function () {
return ["css/font-awesome.min.css", "css/OutSystemsReactWidgets.css"];
};


ELEM.getJsDependencies = function () {
return [];
};


ELEM.getBlocks = function () {
return [OutSystemsUI_Navigation_DEPRECATED_WizardV2_mvc_view, OutSystemsUI_Navigation_DEPRECATED_WizardItemV2_mvc_view, OutSystemsUI_Utilities_AlignCenter_mvc_view, OutSystemsUI_Content_Tooltip_mvc_view, Telcel_Theme_Utils_Wb_ShortText_mvc_view];
};


return ELEM;
};

export default componentFactory()
