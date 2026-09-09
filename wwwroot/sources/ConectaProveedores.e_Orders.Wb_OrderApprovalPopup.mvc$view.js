import { withBaseWebBlock, textWidget as $text, getTranslation, Widget, asPrimitiveValue, ifWidget as $if, useTracing } from "@outsystems/runtime-view-js";
import { Container as OSWidgets$Container, Link as OSWidgets$Link, Image as OSWidgets$Image, List as OSWidgets$List, Expression as OSWidgets$Expression, Button as OSWidgets$Button } from "@outsystems/runtime-widgets-js";
import OutSystemsUI_Utilities_AlignCenter_mvc_view from "./OutSystemsUI.Utilities.AlignCenter.mvc$view.js";
import { createElement } from "react";
import { Navigation as OS$Navigation, Model as OS$Model, BuiltinFunctions as OS$BuiltinFunctions } from "@outsystems/runtime-core-js";
import { SE_scrollbarStyle as ConectaProveedores_staticEntities_scrollbarStyle, SE_orientation as ConectaProveedores_staticEntities_orientation, SE_steps as ConectaProveedores_staticEntities_steps, SE_approvalStatus as ConectaProveedores_staticEntities_approvalStatus } from "./ConectaProveedores.staticEntities.js";
import OutSystemsUI_Interaction_ScrollableArea_mvc_view from "./OutSystemsUI.Interaction.ScrollableArea.mvc$view.js";
import OutSystemsUI_Navigation_DEPRECATED_WizardV2_mvc_view from "./OutSystemsUI.Navigation.DEPRECATED_WizardV2.mvc$view.js";
import OutSystemsUI_Navigation_DEPRECATED_WizardItemV2_mvc_view from "./OutSystemsUI.Navigation.DEPRECATED_WizardItemV2.mvc$view.js";
import ModelFactory from "./ConectaProveedores.e_Orders.Wb_OrderApprovalPopup.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.e_Orders.Wb_OrderApprovalPopup.mvc$controller.js";

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
gridProperties: {
classes: "ThemeGrid_Width11"
},
visible: true,
_idProps: {
service: idService,
uuid: "3"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("Y9DvarFW_0ewruK7IKnAig#Value", "Order Approval"))), createElement(OSWidgets$Container, {
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
enabled: true,
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
_dependencies: []
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "7"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(model.variables.getOrderApprovalsByOrderIdAggr.isDataFetchedAttr, false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "text-align: left; "
},
style: "margin-top-m",
visible: true,
_idProps: {
service: idService,
uuid: "8"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OutSystemsUI_Interaction_ScrollableArea_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
ScrollbarStyle: ConectaProveedores_staticEntities_scrollbarStyle.compact,
Orientation: ConectaProveedores_staticEntities_orientation.vertical
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
uuid: "9",
alias: "2"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
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
uuid: "10",
alias: "3"
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
source: model.variables.getOrderApprovalsByOrderIdAggr.listOut,
style: "list list-group",
tag: "div",
_idProps: {
service: idService,
uuid: "11"
},
_widgetRecordProvider: widgetsRecordProvider,
source_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderApprovalsByOrderIdAggr.dataFetchStatusAttr),
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
Status: model.getCachedValue(idService.getId("eNE6qmi67Ue62Shrt1RTSQ.Status"), function () {
return ((!(model.variables.getOrderApprovalsByOrderIdAggr.listOut.getCurrent(callContext.iterationContext).orderApprovalLevelAttr.approvedOnAttr.equals(OS$BuiltinFunctions.nullDate()))) ? (ConectaProveedores_staticEntities_steps.past) : ((((((model.variables.getOrderApprovalsByOrderIdAggr.listOut.getCurrent(callContext.iterationContext).orderApprovalLevelAttr.approvalStatusIdAttr === ConectaProveedores_staticEntities_approvalStatus.notApproved) || (model.variables.getOrderApprovalsByOrderIdAggr.listOut.getCurrent(callContext.iterationContext).orderApprovalLevelAttr.approvalStatusIdAttr === ConectaProveedores_staticEntities_approvalStatus.toComplement)) || (model.variables.getOrderApprovalsByOrderIdAggr.listOut.getCurrent(callContext.iterationContext).orderApprovalLevelAttr.approvalStatusIdAttr === ConectaProveedores_staticEntities_approvalStatus.inInformationCompletion))) ? (ConectaProveedores_staticEntities_steps.active) : (ConectaProveedores_staticEntities_steps.next))));
}, function () {
return model.variables.getOrderApprovalsByOrderIdAggr.listOut.getCurrent(callContext.iterationContext).orderApprovalLevelAttr.approvedOnAttr;
}, function () {
return model.variables.getOrderApprovalsByOrderIdAggr.listOut.getCurrent(callContext.iterationContext).orderApprovalLevelAttr.approvalStatusIdAttr;
}),
_statusInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderApprovalsByOrderIdAggr.dataFetchStatusAttr)
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
alias: "4"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
icon: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Expression, {
value: ((model.variables.getOrderApprovalsByOrderIdAggr.listOut.getCurrentRowNumber(callContext.iterationContext) + 1)).toString(),
_idProps: {
service: idService,
uuid: "13"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderApprovalsByOrderIdAggr.dataFetchStatusAttr)
})];
}),
label: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "text-align-left",
visible: true,
_idProps: {
service: idService,
uuid: "14"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("opL+58CvNU6AGykj6bpc3A.Value"), function () {
return ((((model.variables.getOrderApprovalsByOrderIdAggr.listOut.getCurrent(callContext.iterationContext).userAttr.nameAttr) !== (""))) ? (model.variables.getOrderApprovalsByOrderIdAggr.listOut.getCurrent(callContext.iterationContext).userAttr.nameAttr) : (model.variables.getOrderApprovalsByOrderIdAggr.listOut.getCurrent(callContext.iterationContext).entraRoleAttr.roleNameAttr));
}, function () {
return model.variables.getOrderApprovalsByOrderIdAggr.listOut.getCurrent(callContext.iterationContext).userAttr.nameAttr;
}, function () {
return model.variables.getOrderApprovalsByOrderIdAggr.listOut.getCurrent(callContext.iterationContext).entraRoleAttr.roleNameAttr;
}),
_idProps: {
service: idService,
uuid: "15"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderApprovalsByOrderIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "font-semi-bold text-align-left",
visible: true,
_idProps: {
service: idService,
uuid: "16"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.variables.getOrderApprovalsByOrderIdAggr.listOut.getCurrent(callContext.iterationContext).userAttr.emailAttr,
_idProps: {
service: idService,
uuid: "17"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderApprovalsByOrderIdAggr.dataFetchStatusAttr)
}))];
})
},
_dependencies: [asPrimitiveValue(model.variables.getOrderApprovalsByOrderIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderApprovalsByOrderIdAggr.listOut.getCurrent(callContext.iterationContext).entraRoleAttr.roleNameAttr), asPrimitiveValue(model.variables.getOrderApprovalsByOrderIdAggr.listOut.getCurrent(callContext.iterationContext).userAttr.emailAttr), asPrimitiveValue(model.variables.getOrderApprovalsByOrderIdAggr.listOut.getCurrent(callContext.iterationContext).userAttr.nameAttr), asPrimitiveValue(model.variables.getOrderApprovalsByOrderIdAggr.listOut.getCurrentRowNumber(callContext.iterationContext))]
})];
}, callContext, idService, "1")
},
_dependencies: [asPrimitiveValue(model.variables.getOrderApprovalsByOrderIdAggr.dataFetchStatusAttr)]
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.getOrderApprovalsByOrderIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderApprovalsByOrderIdAggr.listOut)]
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.getOrderApprovalsByOrderIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderApprovalsByOrderIdAggr.listOut)]
}))];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "list-updating",
visible: true,
_idProps: {
service: idService,
uuid: "18"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "text-align: right;"
},
style: "margin-top-base",
visible: true,
_idProps: {
service: idService,
uuid: "19"
},
_widgetRecordProvider: widgetsRecordProvider
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
uuid: "20"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("0lTzKHS900K_wS9RRurmAg#Value", "Close"))))));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "Wb_OrderApprovalPopup",
functionKey: "7f9dfd12-67fe-4835-b56d-5f1a79ee5068",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "e_Orders.Wb_OrderApprovalPopup",
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
return [OutSystemsUI_Utilities_AlignCenter_mvc_view, OutSystemsUI_Interaction_ScrollableArea_mvc_view, OutSystemsUI_Navigation_DEPRECATED_WizardV2_mvc_view, OutSystemsUI_Navigation_DEPRECATED_WizardItemV2_mvc_view];
};


return ELEM;
};

export default componentFactory()
