import { withBaseWebBlock, textWidget as $text, getTranslation, ifWidget as $if, Widget, asPrimitiveValue, useTracing } from "@outsystems/runtime-view-js";
import { Container as OSWidgets$Container, Button as OSWidgets$Button, Expression as OSWidgets$Expression, Icon as OSWidgets$Icon, Link as OSWidgets$Link, Popup as OSWidgets$Popup } from "@outsystems/runtime-widgets-js";
import { Model as OS$Model, Injector as OS$Injector, ServiceNames as OS$ServiceNames, BuiltinFunctions as OS$BuiltinFunctions } from "@outsystems/runtime-core-js";
import ConectaProveedoresController$default from "./ConectaProveedores.controller.js";
import { createElement } from "react";
import OutSystemsUI_Navigation_Submenu_mvc_view from "./OutSystemsUI.Navigation.Submenu.mvc$view.js";
import { SE_folioStatus as ConectaProveedores_staticEntities_folioStatus } from "./ConectaProveedores.staticEntities.js";
import ConectaProveedores_y_Utils_Wb_PopupApprove_mvc_view from "./ConectaProveedores.y_Utils.Wb_PopupApprove.mvc$view.js";
import ConectaProveedores_y_Utils_Wb_ConfirmPopup_mvc_view from "./ConectaProveedores.y_Utils.Wb_ConfirmPopup.mvc$view.js";
import ConectaProveedores_j_FoliosSAE_Wb_ReassignFolioPopup_mvc_view from "./ConectaProveedores.j_FoliosSAE.Wb_ReassignFolioPopup.mvc$view.js";
import ConectaProveedores_j_FoliosSAE_Wb_EstablishFlowPopup_mvc_view from "./ConectaProveedores.j_FoliosSAE.Wb_EstablishFlowPopup.mvc$view.js";
import ConectaProveedores_k_Deviations_Wb_CompleteEntry_mvc_view from "./ConectaProveedores.k_Deviations.Wb_CompleteEntry.mvc$view.js";
import ConectaProveedores_y_Utils_Wb_CancelFolioPopup_mvc_view from "./ConectaProveedores.y_Utils.Wb_CancelFolioPopup.mvc$view.js";
import ConectaProveedores_j_FoliosSAE_Wb_IncorrectAssignmentPopup_mvc_view from "./ConectaProveedores.j_FoliosSAE.Wb_IncorrectAssignmentPopup.mvc$view.js";
import ConectaProveedores_j_FoliosSAE_Wb_ReassignFolioFromRejectPopup_mvc_view from "./ConectaProveedores.j_FoliosSAE.Wb_ReassignFolioFromRejectPopup.mvc$view.js";
import ModelFactory from "./ConectaProveedores.j_FoliosSAE.Wb_FolioActions.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.j_FoliosSAE.Wb_FolioActions.mvc$controller.js";

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
return createElement("div", props.rootNodeProperties, $if(model.variables.getFolioApprovalLevelByIdAggr.isDataFetchedAttr, false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: true,
extendedProperties: {
style: "height: 40px;"
},
gridProperties: {
classes: "OSInline"
},
visible: (!(model.variables.i_DirectReportIn)),
_idProps: {
service: idService,
uuid: "0"
},
_widgetRecordProvider: widgetsRecordProvider,
visible_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._i_DirectReportInDataFetchStatus)
}, $if((model.variables.getFolioApprovalLevelByIdAggr.listOut.getCurrent(callContext.iterationContext).showActionsAttr && (!(ConectaProveedoresController$default.checkProveedorRole$Action(callContext).hasRoleOut))), false, this, function () {
return [createElement(OSWidgets$Button, {
enabled: true,
extendedProperties: {
style: "width: auto; margin-right: var(--space-base); "
},
isDefault: false,
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.wb_b_ApprovePopupOpenClose$Action(false, controller.callContext(eventHandlerContext));
});
;
},
style: "btn btn-approve",
visible: true,
_idProps: {
service: idService,
uuid: "1"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("4PhyjUfFMkmfw1G9qrHi2g#Value", "Approve")))];
}, function () {
return [$if((model.variables.getUserInfoDataAct.isAllowedReassignOut && model.variables.getFolioTypeDADataAct.o_IsActiveDEV_HU13045Out), false, this, function () {
return [createElement(OSWidgets$Button, {
enabled: true,
extendedProperties: {
style: "width: auto; margin-right: var(--space-base); "
},
isDefault: false,
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.wb_c_ReassignFolioFromRejectPopupOpenClose$Action(false, controller.callContext(eventHandlerContext));
});
;
},
style: "btn btn-approve",
visible: true,
_idProps: {
service: idService,
uuid: "2"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("2vPGe4oOCUqKziA4N_rNnQ#Value", "Reassign")))];
}, function () {
return [];
})];
}), createElement(OutSystemsUI_Navigation_Submenu_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
ExtendedClass: "kebab-menu--unique"
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
initialized$Action: function (submenuIdIn) {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.submenuInitialized$Action(controller.callContext(eventHandlerContext));

;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
name: "Submenu",
alias: "1"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
menu: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "width: auto;"
},
style: "btn btn-edit",
visible: true,
_idProps: {
service: idService,
uuid: "4"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
style: "margin-right-s",
value: model.getCachedValue(idService.getId("mdA_yS5c8ku+jD2Nt0SzfQ.Value"), function () {
return ((model.variables.getFolioApprovalLevelByIdAggr.listOut.getCurrent(callContext.iterationContext).showActionsAttr) ? (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("QGI_aKHlD0aVBGMRGkLmNw#ValueExpression.2404213.1", "More")) : (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("QGI_aKHlD0aVBGMRGkLmNw#ValueExpression.415178366.1", "Options")));
}, function () {
return model.variables.getFolioApprovalLevelByIdAggr.listOut.getCurrent(callContext.iterationContext).showActionsAttr;
}),
_idProps: {
service: idService,
uuid: "5"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioApprovalLevelByIdAggr.dataFetchStatusAttr)
}), createElement(OSWidgets$Icon, {
gridProperties: {
classes: "ThemeGrid_MarginGutter"
},
icon: "ellipsis-v",
iconSize: /*FontSize*/ 0,
style: "icon",
visible: true,
_idProps: {
service: idService,
uuid: "6"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
}),
items: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: true,
visible: model.getCachedValue(idService.getId("9s9Jdu4MREyskhoUqBpxAQ.Visible"), function () {
return (((!(model.variables.l_IsFirstApproverVar)) && model.variables.getFolioApprovalLevelByIdAggr.listOut.getCurrent(callContext.iterationContext).showActionsAttr) && (!(ConectaProveedoresController$default.checkProveedorRole$Action(callContext).hasRoleOut)));
}, function () {
return model.variables.l_IsFirstApproverVar;
}, function () {
return model.variables.getFolioApprovalLevelByIdAggr.listOut.getCurrent(callContext.iterationContext).showActionsAttr;
}),
_idProps: {
service: idService,
uuid: "7"
},
_widgetRecordProvider: widgetsRecordProvider,
visible_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioApprovalLevelByIdAggr.dataFetchStatusAttr)
}, createElement(OSWidgets$Link, {
enabled: true,
gridProperties: {
classes: "OSFillParent"
},
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.wb_a_OpenClosePopUp$Action(false, "False", false, true, false, false, controller.callContext(eventHandlerContext));
});
;
},
visible: true,
_idProps: {
service: idService,
uuid: "8"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("PDu9oPLYH0asvNelkIwIQQ#Value", "Reject Approval")))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "9"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Link, {
enabled: true,
gridProperties: {
classes: "OSFillParent"
},
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.wb_a_OpenClosePopUp$Action(false, "False", false, false, true, false, controller.callContext(eventHandlerContext));
});
;
},
visible: true,
_idProps: {
service: idService,
uuid: "10"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("Danen5bX_E+bfQWWvY5Vrg#Value", "Comment")))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: true,
visible: model.getCachedValue(idService.getId("Yg8PuV4boU6l6EfaiKTtPw.Visible"), function () {
return (model.variables.getFolioApprovalLevelByIdAggr.listOut.getCurrent(callContext.iterationContext).showActionsAttr && (!(ConectaProveedoresController$default.checkProveedorRole$Action(callContext).hasRoleOut)));
}, function () {
return model.variables.getFolioApprovalLevelByIdAggr.listOut.getCurrent(callContext.iterationContext).showActionsAttr;
}),
_idProps: {
service: idService,
uuid: "11"
},
_widgetRecordProvider: widgetsRecordProvider,
visible_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioApprovalLevelByIdAggr.dataFetchStatusAttr)
}, createElement(OSWidgets$Link, {
enabled: true,
gridProperties: {
classes: "OSFillParent"
},
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.wb_a_OpenClosePopUp$Action(false, "False", true, false, false, false, controller.callContext(eventHandlerContext));
});
;
},
visible: true,
_idProps: {
service: idService,
uuid: "12"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("S5a0TfIhE0SfEZViwIy21w#Value", "Request Evidence")))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: true,
visible: model.getCachedValue(idService.getId("04To3I4_jEaaviwKHDOl9A.Visible"), function () {
return (((model.variables.l_IsFirstApproverVar && model.variables.getFolioApprovalLevelByIdAggr.listOut.getCurrent(callContext.iterationContext).showActionsAttr) && (!(ConectaProveedoresController$default.checkProveedorRole$Action(callContext).hasRoleOut))) && model.variables.getFolioTypeDADataAct.o_IsActiveDEV_HU13045Out);
}, function () {
return model.variables.l_IsFirstApproverVar;
}, function () {
return model.variables.getFolioApprovalLevelByIdAggr.listOut.getCurrent(callContext.iterationContext).showActionsAttr;
}, function () {
return model.variables.getFolioTypeDADataAct.o_IsActiveDEV_HU13045Out;
}),
_idProps: {
service: idService,
uuid: "13"
},
_widgetRecordProvider: widgetsRecordProvider,
visible_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioApprovalLevelByIdAggr.dataFetchStatusAttr, model.variables.getFolioTypeDADataAct.dataFetchStatusAttr)
}, createElement(OSWidgets$Link, {
enabled: true,
gridProperties: {
classes: "OSFillParent"
},
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.wb_b_IncorrectAssignmentPopupOpenClose$Action(false, controller.callContext(eventHandlerContext));
});
;
},
visible: true,
_idProps: {
service: idService,
uuid: "14"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("uhAVXNOeN0SCPq9jsKe1Qg#Value", "Incorrect assignment")))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: true,
visible: model.getCachedValue(idService.getId("yr7H7rLAgEmkbGwJ_JtUNg.Visible"), function () {
return (((model.variables.l_IsFirstApproverVar && model.variables.getFolioApprovalLevelByIdAggr.listOut.getCurrent(callContext.iterationContext).showActionsAttr) && (!(ConectaProveedoresController$default.checkProveedorRole$Action(callContext).hasRoleOut))) && model.variables.getFolioTypeDADataAct.o_ShowOptionsOut);
}, function () {
return model.variables.l_IsFirstApproverVar;
}, function () {
return model.variables.getFolioApprovalLevelByIdAggr.listOut.getCurrent(callContext.iterationContext).showActionsAttr;
}, function () {
return model.variables.getFolioTypeDADataAct.o_ShowOptionsOut;
}),
_idProps: {
service: idService,
uuid: "15"
},
_widgetRecordProvider: widgetsRecordProvider,
visible_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioApprovalLevelByIdAggr.dataFetchStatusAttr, model.variables.getFolioTypeDADataAct.dataFetchStatusAttr)
}, createElement(OSWidgets$Link, {
enabled: true,
gridProperties: {
classes: "OSFillParent"
},
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.wb_b_ReassignPopupOpenClose$Action(false, controller.callContext(eventHandlerContext));
});
;
},
visible: true,
_idProps: {
service: idService,
uuid: "16"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("+mn7Y7I_90S9lSnZouC8fw#Value", "Reassign Approval")))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: true,
visible: model.getCachedValue(idService.getId("9NXSfi+5JEGEueXRAvlXng.Visible"), function () {
return (((model.variables.l_IsFirstApproverVar && model.variables.getFolioApprovalLevelByIdAggr.listOut.getCurrent(callContext.iterationContext).showActionsAttr) && (!(ConectaProveedoresController$default.checkProveedorRole$Action(callContext).hasRoleOut))) && model.variables.getFolioTypeDADataAct.o_ShowOptionsOut);
}, function () {
return model.variables.l_IsFirstApproverVar;
}, function () {
return model.variables.getFolioApprovalLevelByIdAggr.listOut.getCurrent(callContext.iterationContext).showActionsAttr;
}, function () {
return model.variables.getFolioTypeDADataAct.o_ShowOptionsOut;
}),
_idProps: {
service: idService,
uuid: "17"
},
_widgetRecordProvider: widgetsRecordProvider,
visible_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioApprovalLevelByIdAggr.dataFetchStatusAttr, model.variables.getFolioTypeDADataAct.dataFetchStatusAttr)
}, createElement(OSWidgets$Link, {
enabled: true,
gridProperties: {
classes: "OSFillParent"
},
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.wb_b_EstablishFlowPopupOpenClose$Action(false, controller.callContext(eventHandlerContext));
});
;
},
visible: true,
_idProps: {
service: idService,
uuid: "18"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("_9tjWp+RYEufx8bhNjaXqg#Value", "Establish Approval Workflow")))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: true,
visible: model.getCachedValue(idService.getId("tWLWqNtiJ0CVSlYTBt6Zgw.Visible"), function () {
return (((model.variables.l_IsFirstApproverVar && model.variables.getFolioApprovalLevelByIdAggr.listOut.getCurrent(callContext.iterationContext).showActionsAttr) && (!(ConectaProveedoresController$default.checkProveedorRole$Action(callContext).hasRoleOut))) || (model.variables.getUserInfoDataAct.isAllowedReassignOut && model.variables.getFolioTypeDADataAct.o_IsActiveDEV_HU13045Out));
}, function () {
return model.variables.l_IsFirstApproverVar;
}, function () {
return model.variables.getFolioApprovalLevelByIdAggr.listOut.getCurrent(callContext.iterationContext).showActionsAttr;
}, function () {
return model.variables.getUserInfoDataAct.isAllowedReassignOut;
}, function () {
return model.variables.getFolioTypeDADataAct.o_IsActiveDEV_HU13045Out;
}),
_idProps: {
service: idService,
uuid: "19"
},
_widgetRecordProvider: widgetsRecordProvider,
visible_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioApprovalLevelByIdAggr.dataFetchStatusAttr, model.variables.getUserInfoDataAct.dataFetchStatusAttr, model.variables.getFolioTypeDADataAct.dataFetchStatusAttr)
}, createElement(OSWidgets$Link, {
enabled: true,
gridProperties: {
classes: "OSFillParent"
},
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.wb_a_OpenClosePopUp$Action(false, "False", false, false, false, true, controller.callContext(eventHandlerContext));
});
;
},
visible: true,
_idProps: {
service: idService,
uuid: "20"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("x_aVjA5gPU+kZZcLY7_1ug#Value", "Cancel")))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: true,
visible: model.getCachedValue(idService.getId("LyTYJ+_t+Ea4rT+ODy59Lg.Visible"), function () {
return ((ConectaProveedoresController$default.checkDesviacionesRole$Action(callContext).hasRoleOut && (((model.variables.getFolioApprovalLevelByIdAggr.listOut.getCurrent(callContext.iterationContext).folioStatusAttr.idAttr === ConectaProveedores_staticEntities_folioStatus.failedEntryRequest) || (model.variables.getFolioApprovalLevelByIdAggr.listOut.getCurrent(callContext.iterationContext).folioStatusAttr.idAttr === ConectaProveedores_staticEntities_folioStatus.failedExitRequest)) || (model.variables.getFolioApprovalLevelByIdAggr.listOut.getCurrent(callContext.iterationContext).folioStatusAttr.idAttr === ConectaProveedores_staticEntities_folioStatus.pendingEntryRequest))) && (!(ConectaProveedoresController$default.checkProveedorRole$Action(callContext).hasRoleOut)));
}, function () {
return model.variables.getFolioApprovalLevelByIdAggr.listOut.getCurrent(callContext.iterationContext).folioStatusAttr.idAttr;
}),
_idProps: {
service: idService,
uuid: "21"
},
_widgetRecordProvider: widgetsRecordProvider,
visible_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioApprovalLevelByIdAggr.dataFetchStatusAttr)
}, createElement(OSWidgets$Link, {
enabled: true,
gridProperties: {
classes: "OSFillParent"
},
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.wb_b_CompleteEntryPopupOpenClose$Action(false, controller.callContext(eventHandlerContext));
});
;
},
visible: true,
_idProps: {
service: idService,
uuid: "22"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("+n1CarbM1kqm9O+SUqVrpw#Value", "Complete Entry")))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: true,
visible: model.getCachedValue(idService.getId("0LdYf+K6XEybq+hp6SZH2A.Visible"), function () {
return ((ConectaProveedoresController$default.checkDesviacionesRole$Action(callContext).hasRoleOut && (((model.variables.getFolioApprovalLevelByIdAggr.listOut.getCurrent(callContext.iterationContext).folioStatusAttr.idAttr === ConectaProveedores_staticEntities_folioStatus.failedEntryRequest) || (model.variables.getFolioApprovalLevelByIdAggr.listOut.getCurrent(callContext.iterationContext).folioStatusAttr.idAttr === ConectaProveedores_staticEntities_folioStatus.failedExitRequest)) || (model.variables.getFolioApprovalLevelByIdAggr.listOut.getCurrent(callContext.iterationContext).folioStatusAttr.idAttr === ConectaProveedores_staticEntities_folioStatus.pendingEntryRequest))) && (!(ConectaProveedoresController$default.checkProveedorRole$Action(callContext).hasRoleOut)));
}, function () {
return model.variables.getFolioApprovalLevelByIdAggr.listOut.getCurrent(callContext.iterationContext).folioStatusAttr.idAttr;
}),
_idProps: {
service: idService,
uuid: "23"
},
_widgetRecordProvider: widgetsRecordProvider,
visible_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioApprovalLevelByIdAggr.dataFetchStatusAttr)
}, createElement(OSWidgets$Link, {
enabled: true,
gridProperties: {
classes: "OSFillParent"
},
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.wb_b_ResendEntryPopupOpenClose$Action(false, controller.callContext(eventHandlerContext));
});
;
},
visible: true,
_idProps: {
service: idService,
uuid: "24"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("mIi_TPD0iU6w+GTEu9mJrA#Value", "Resend Entry")))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: true,
visible: model.getCachedValue(idService.getId("qPfcRyFz00itg3d5cSQB6Q.Visible"), function () {
return ((model.variables.getUserInfoDataAct.isAllowedCancelFolioOut && (!(ConectaProveedoresController$default.checkProveedorRole$Action(callContext).hasRoleOut))) && ((model.variables.getFolioTypeDADataAct.o_IsActiveDEV_HU13045Out) ? ((!(model.variables.getUserInfoDataAct.isAllowedReassignOut))) : (true)));
}, function () {
return model.variables.getUserInfoDataAct.isAllowedCancelFolioOut;
}, function () {
return model.variables.getFolioTypeDADataAct.o_IsActiveDEV_HU13045Out;
}, function () {
return model.variables.getUserInfoDataAct.isAllowedReassignOut;
}),
_idProps: {
service: idService,
uuid: "25"
},
_widgetRecordProvider: widgetsRecordProvider,
visible_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getUserInfoDataAct.dataFetchStatusAttr, model.variables.getFolioTypeDADataAct.dataFetchStatusAttr)
}, createElement(OSWidgets$Link, {
enabled: true,
gridProperties: {
classes: "OSFillParent"
},
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.wb_b_CancelFolioPopupOpenClose$Action(false, controller.callContext(eventHandlerContext));
});
;
},
visible: true,
_idProps: {
service: idService,
uuid: "26"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("2ktDWLHZp06nbfwxNQsyhw#Value", "Cancel Folio"))))];
})
},
_dependencies: [asPrimitiveValue(model.variables.getUserInfoDataAct.isAllowedCancelFolioOut), asPrimitiveValue(model.variables.getUserInfoDataAct.isAllowedReassignOut), asPrimitiveValue(model.variables.getFolioTypeDADataAct.o_ShowOptionsOut), asPrimitiveValue(model.variables.getFolioTypeDADataAct.o_IsActiveDEV_HU13045Out), asPrimitiveValue(model.variables.l_IsFirstApproverVar), asPrimitiveValue(model.variables.getUserInfoDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioTypeDADataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioApprovalLevelByIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioApprovalLevelByIdAggr.listOut.getCurrent(callContext.iterationContext).folioStatusAttr.idAttr), asPrimitiveValue(model.variables.getFolioApprovalLevelByIdAggr.listOut.getCurrent(callContext.iterationContext).showActionsAttr)]
}))];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "list-updating",
visible: true,
_idProps: {
service: idService,
uuid: "27"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}), createElement(OSWidgets$Popup, {
extendedProperties: {
style: "padding: var(--space-base); width: 700px;"
},
showPopup: model.variables.l_ShowPopUpVar,
style: "popup-dialog card",
_idProps: {
service: idService,
uuid: "28"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(ConectaProveedores_y_Utils_Wb_PopupApprove_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_Title: model.variables.l_PopupTitleVar,
i_IsCommentNeeded: true
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
close$Action: function (isOkIn, commentIn) {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.wb_a_OpenClosePopUp$Action(isOkIn, commentIn, model.variables.l_EvidenceRequestVar, model.variables.l_RejectVar, model.variables.l_CommentVar, model.variables.l_CancelVar, controller.callContext(eventHandlerContext));
});
;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "29",
alias: "2"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})), createElement(OSWidgets$Popup, {
extendedProperties: {
style: "padding: var(--space-base); "
},
showPopup: model.variables.l_ShowApprovePopupVar,
style: "popup-dialog card",
_idProps: {
service: idService,
name: "Approve"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(ConectaProveedores_y_Utils_Wb_ConfirmPopup_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_PopupTitle: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("R32KCMpyU0yAiQIQOmW2Pw#Value.-1679196512.1", "Confirm"),
i_ConfirmationText: model.getCachedValue(idService.getId("ngVMqAX0vkCab61uY465aA.i_ConfirmationText"), function () {
return (((((OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("WmzC5E9Fg0qoc0FbTCj4lg#Value.-1246251742.1", "The amount of the SAEC folio being authorized is") + " ") + OS$BuiltinFunctions.formatCurrency(model.variables.getFolioApprovalLevelByIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.totalAmountAttr, "", 2, ".", ",")) + model.variables.getFolioApprovalLevelByIdAggr.listOut.getCurrent(callContext.iterationContext).currencyAttr.codeAttr) + " ") + OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("WmzC5E9Fg0qoc0FbTCj4lg#Value.-1462790376.1", "Is that correct?"));
}, function () {
return model.variables.getFolioApprovalLevelByIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.totalAmountAttr;
}, function () {
return model.variables.getFolioApprovalLevelByIdAggr.listOut.getCurrent(callContext.iterationContext).currencyAttr.codeAttr;
}),
_i_ConfirmationTextInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioApprovalLevelByIdAggr.dataFetchStatusAttr)
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
close$Action: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.wb_b_ApprovePopupOpenClose$Action(false, controller.callContext(eventHandlerContext));
});
;
},
confirm$Action: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.wb_b_ApprovePopupOpenClose$Action(true, controller.callContext(eventHandlerContext));
});
;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "31",
alias: "3"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})), createElement(OSWidgets$Popup, {
extendedProperties: {
style: "padding: var(--space-base); "
},
showPopup: model.variables.l_ShowReassignPopupVar,
style: "popup-dialog card",
_idProps: {
service: idService,
name: "Reassign"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(ConectaProveedores_j_FoliosSAE_Wb_ReassignFolioPopup_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_FolioId: model.variables.i_FolioIdIn,
_i_FolioIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._i_FolioIdInDataFetchStatus),
i_FolioApprovalLevelId: model.variables.getFolioApprovalLevelByIdAggr.listOut.getCurrent(callContext.iterationContext).folioApprovalLevelAttr.idAttr,
_i_FolioApprovalLevelIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioApprovalLevelByIdAggr.dataFetchStatusAttr)
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
close$Action: function (i_IsRefreshIn, i_AssignUserIdIn) {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.wb_b_ReassignPopupOpenClose$Action(i_IsRefreshIn, controller.callContext(eventHandlerContext));
});
;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "33",
alias: "4"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})), createElement(OSWidgets$Popup, {
extendedProperties: {
style: "padding: var(--space-base); "
},
showPopup: model.variables.l_ShowEstablishFlowPopupVar,
style: "popup-dialog card",
_idProps: {
service: idService,
name: "EstablishFlow"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(ConectaProveedores_j_FoliosSAE_Wb_EstablishFlowPopup_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_FolioId: model.variables.i_FolioIdIn,
_i_FolioIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._i_FolioIdInDataFetchStatus)
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
close$Action: function (isRefreshIn) {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.wb_b_EstablishFlowPopupOpenClose$Action(isRefreshIn, controller.callContext(eventHandlerContext));
});
;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "35",
alias: "5"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})), createElement(OSWidgets$Popup, {
extendedProperties: {
style: "padding: var(--space-base); "
},
showPopup: model.variables.l_ShowCompleteEntryPopupVar,
style: "popup-dialog card",
_idProps: {
service: idService,
name: "CompleteEntry"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(ConectaProveedores_k_Deviations_Wb_CompleteEntry_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_FolioId: model.variables.i_FolioIdIn,
_i_FolioIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._i_FolioIdInDataFetchStatus)
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
closePopup$Action: function (i_IsSaveIn) {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.wb_b_CompleteEntryPopupOpenClose$Action(i_IsSaveIn, controller.callContext(eventHandlerContext));
});
;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "37",
alias: "6"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})), createElement(OSWidgets$Popup, {
extendedProperties: {
style: "padding: var(--space-base); "
},
showPopup: model.variables.l_ShowResendEntryPopupVar,
style: "popup-dialog card",
_idProps: {
service: idService,
name: "ResendEntry"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(ConectaProveedores_y_Utils_Wb_ConfirmPopup_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_PopupTitle: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("8txWTYuOVEu_2DcoDng7iQ#Value.-1679196512.1", "Confirm"),
i_ConfirmationText: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("Swf7TYXHkEeLPNaH7+ntCw#Value.-444843842.1", "Are you sure you want to resend entry?")
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
close$Action: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.wb_b_ResendEntryPopupOpenClose$Action(false, controller.callContext(eventHandlerContext));
});
;
},
confirm$Action: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.wb_b_ResendEntryPopupOpenClose$Action(true, controller.callContext(eventHandlerContext));
});
;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "39",
alias: "7"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})), createElement(OSWidgets$Popup, {
extendedProperties: {
style: "padding: var(--space-base); "
},
showPopup: model.variables.i_ShowCancelPopupVar,
style: "popup-dialog card",
_idProps: {
service: idService,
name: "CancelFolio"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(ConectaProveedores_y_Utils_Wb_CancelFolioPopup_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
FolioId: model.variables.i_FolioIdIn,
_folioIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._i_FolioIdInDataFetchStatus)
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
close$Action: function (isRefreshIn) {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.wb_b_CancelFolioPopupOpenClose$Action(isRefreshIn, controller.callContext(eventHandlerContext));
});
;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "41",
alias: "8"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})), createElement(OSWidgets$Popup, {
extendedProperties: {
style: "padding: var(--space-base); min-width: 650px;"
},
showPopup: model.variables.l_ShowIncorrectAssignmentPopupVar,
style: "popup-dialog card",
_idProps: {
service: idService,
name: "IncorrectAssignment"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(ConectaProveedores_j_FoliosSAE_Wb_IncorrectAssignmentPopup_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_FolioId: model.variables.i_FolioIdIn,
_i_FolioIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._i_FolioIdInDataFetchStatus),
i_FolioApprovalLevelId: model.variables.getFolioApprovalLevelByIdAggr.listOut.getCurrent(callContext.iterationContext).folioApprovalLevelAttr.idAttr,
_i_FolioApprovalLevelIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioApprovalLevelByIdAggr.dataFetchStatusAttr)
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
close$Action: function (i_IsRefreshIn) {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.wb_b_IncorrectAssignmentPopupOpenClose$Action(i_IsRefreshIn, controller.callContext(eventHandlerContext));
});
;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "43",
alias: "9"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})), createElement(OSWidgets$Popup, {
extendedProperties: {
style: "padding: var(--space-base); min-width: 650px;"
},
showPopup: model.variables.l_ShowReassignFolioFromRejectPopupVar,
style: "popup-dialog card",
_idProps: {
service: idService,
name: "ReassignFolioFromReject"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(ConectaProveedores_j_FoliosSAE_Wb_ReassignFolioFromRejectPopup_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_FolioId: model.variables.i_FolioIdIn,
_i_FolioIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._i_FolioIdInDataFetchStatus)
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
close$Action: function (i_IsRefreshIn) {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.wb_c_ReassignFolioFromRejectPopupOpenClose$Action(i_IsRefreshIn, controller.callContext(eventHandlerContext));
});
;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "45",
alias: "10"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "Wb_FolioActions",
functionKey: "37a77337-f71a-4741-9827-8a7d6349d33f",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "j_FoliosSAE.Wb_FolioActions",
modelFactory: ModelFactory,
controllerFactory: ControllerFactory
});


ELEM.getCssDependencies = function () {
return ["css/font-awesome.min.css", "css/OutSystemsReactWidgets.css", "css/ConectaProveedores.j_FoliosSAE.Wb_FolioActions.css"];
};


ELEM.getJsDependencies = function () {
return [];
};


ELEM.getBlocks = function () {
return [OutSystemsUI_Navigation_Submenu_mvc_view, ConectaProveedores_y_Utils_Wb_PopupApprove_mvc_view, ConectaProveedores_y_Utils_Wb_ConfirmPopup_mvc_view, ConectaProveedores_j_FoliosSAE_Wb_ReassignFolioPopup_mvc_view, ConectaProveedores_j_FoliosSAE_Wb_EstablishFlowPopup_mvc_view, ConectaProveedores_k_Deviations_Wb_CompleteEntry_mvc_view, ConectaProveedores_y_Utils_Wb_CancelFolioPopup_mvc_view, ConectaProveedores_j_FoliosSAE_Wb_IncorrectAssignmentPopup_mvc_view, ConectaProveedores_j_FoliosSAE_Wb_ReassignFolioFromRejectPopup_mvc_view];
};


return ELEM;
};

export default componentFactory()
