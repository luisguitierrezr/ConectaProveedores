import { withBaseWebScreen, textWidget as $text, getTranslation, Widget, ifWidget as $if, asPrimitiveValue, useTracing } from "@outsystems/runtime-view-js";
import ConectaProveedores_a_Layouts_LayoutTopMenu_mvc_view from "./ConectaProveedores.a_Layouts.LayoutTopMenu.mvc$view.js";
import { Container as OSWidgets$Container, Image as OSWidgets$Image, Link as OSWidgets$Link, Text as OSWidgets$Text, Expression as OSWidgets$Expression, Icon as OSWidgets$Icon, Button as OSWidgets$Button, Popup as OSWidgets$Popup, Form as OSWidgets$Form, Label as OSWidgets$Label, Input as OSWidgets$Input, List as OSWidgets$List, TableRecords as OSWidgets$TableRecords, HeaderCell as OSWidgets$HeaderCell, RowCell as OSWidgets$RowCell } from "@outsystems/runtime-widgets-js";
import { Navigation as OS$Navigation, Transitions as OS$Transitions, Injector as OS$Injector, ServiceNames as OS$ServiceNames, Model as OS$Model, BuiltinFunctions as OS$BuiltinFunctions, DataConversion as OS$DataConversion, GenericTypeCache as OS$GenericTypeCache, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import { createElement } from "react";
import Telcel_Theme_Utils_Wb_Status_mvc_view from "./Telcel_Theme.Utils.Wb_Status.mvc$view.js";
import ConectaProveedoresController$default, { getEnviroment$Action as ConectaProveedoresController$getEnviroment$Action } from "./ConectaProveedores.controller.js";
import { ST_f14441a8387aba6d017931caef70dd11Structure, ST_62dd5b695df6cdb1dddea5855e8718baStructure } from "./ConectaProveedores.model.js";
import { SE_approvalStatus as ConectaProveedores_staticEntities_approvalStatus, SE_folioStatus as ConectaProveedores_staticEntities_folioStatus, SE_orientation as ConectaProveedores_staticEntities_orientation, SE_approvalProcessType as ConectaProveedores_staticEntities_approvalProcessType, SE_scrollbarStyle as ConectaProveedores_staticEntities_scrollbarStyle } from "./ConectaProveedores.staticEntities.js";
import ConectaProveedores_y_Utils_Wb_TimelineUsersV2_mvc_view from "./ConectaProveedores.y_Utils.Wb_TimelineUsersV2.mvc$view.js";
import ConectaProveedores_y_Utils_Wb_ConfirmPopup_mvc_view from "./ConectaProveedores.y_Utils.Wb_ConfirmPopup.mvc$view.js";
import ConectaProveedores_j_FoliosSAE_Wb_FolioActions_mvc_view from "./ConectaProveedores.j_FoliosSAE.Wb_FolioActions.mvc$view.js";
import { ST_e3f9af4171d5e4a41700770295d05c77Structure } from "./OutSystemsUI.model.js";
import OutSystemsUI_Navigation_Tabs_mvc_view from "./OutSystemsUI.Navigation.Tabs.mvc$view.js";
import OutSystemsUI_Navigation_TabsHeaderItem_mvc_view from "./OutSystemsUI.Navigation.TabsHeaderItem.mvc$view.js";
import OutSystemsUI_Navigation_TabsContentItem_mvc_view from "./OutSystemsUI.Navigation.TabsContentItem.mvc$view.js";
import ConectaProveedores_j_FoliosSAE_Wb_SAECDetailMain_mvc_view from "./ConectaProveedores.j_FoliosSAE.Wb_SAECDetailMain.mvc$view.js";
import OutSystemsUI_Adaptive_Columns2_mvc_view from "./OutSystemsUI.Adaptive.Columns2.mvc$view.js";
import OutSystemsUI_Interaction_InputWithIcon_mvc_view from "./OutSystemsUI.Interaction.InputWithIcon.mvc$view.js";
import InputMasks_InputMaskReactFlow_MaskCurrency_mvc_view from "./InputMasks.InputMaskReactFlow.MaskCurrency.mvc$view.js";
import ConectaProveedores_j_FoliosSAE_Wb_SAECDetailPositions_mvc_view from "./ConectaProveedores.j_FoliosSAE.Wb_SAECDetailPositions.mvc$view.js";
import OutSystemsUI_Interaction_ScrollableArea_mvc_view from "./OutSystemsUI.Interaction.ScrollableArea.mvc$view.js";
import OutSystemsUI_Content_Tooltip_mvc_view from "./OutSystemsUI.Content.Tooltip.mvc$view.js";
import OutSystemsUI_Navigation_Pagination_mvc_view from "./OutSystemsUI.Navigation.Pagination.mvc$view.js";
import ConectaProveedores_j_FoliosSAE_Wb_SAECFilesPreview_mvc_view from "./ConectaProveedores.j_FoliosSAE.Wb_SAECFilesPreview.mvc$view.js";
import ConectaProveedores_j_FoliosSAE_Wb_FolioFilesPreview_mvc_view from "./ConectaProveedores.j_FoliosSAE.Wb_FolioFilesPreview.mvc$view.js";
import ConectaProveedores_y_Logs_Wb_FolioLogs_mvc_view from "./ConectaProveedores.y_Logs.Wb_FolioLogs.mvc$view.js";
import ConectaProveedores_j_FoliosSAE_Wb_SAECInvoices_mvc_view from "./ConectaProveedores.j_FoliosSAE.Wb_SAECInvoices.mvc$view.js";
import ConectaProveedores_j_FoliosSAE_Wb_ForeignSupplierInvoiceDetails_mvc_view from "./ConectaProveedores.j_FoliosSAE.Wb_ForeignSupplierInvoiceDetails.mvc$view.js";
import ModelFactory from "./ConectaProveedores.j_FoliosSAE.FolioSAE_Details.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.j_FoliosSAE.FolioSAE_Details.mvc$controller.js";
import { ICON_LIBRARY_NAME, ICON_MAPPINGS, WEIGHT_MAPPINGS, SIZE_MAPPINGS } from "./Telcel_Theme.Telcel_Theme_Theme.mappings.js";

var componentFactory = function () {
var ELEM = withBaseWebScreen(function (props) {
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
return createElement("div", props.rootNodeProperties, createElement(ConectaProveedores_a_Layouts_LayoutTopMenu_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
Initiative: "FCP",
ChatBotIsEnable: true
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
uuid: "0",
alias: "1"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
breadcrumbs: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "1"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
extendedProperties: {
style: "margin-right: 5px;"
},
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Icon_inicio2025.svg"),
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "2"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "OSInline"
},
visible: true,
_idProps: {
service: idService,
uuid: "3"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Link, {
enabled: true,
transition: OS$Transitions.createTransition(OS$Transitions.TransitionAnimation.Default),
url: OS$Navigation.generateScreenURL("ConectaProveedores", "Homepage", {}),
visible: true,
_idProps: {
service: idService,
uuid: "4"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
style: "breadcrumb-before-page-link font-semi-bold",
text: [$text(getTranslation("8gQcObM_MkeaAFD4AcmUYA#Value", "Homepage"))],
_idProps: {
service: idService,
uuid: "5"
},
_widgetRecordProvider: widgetsRecordProvider
}))), createElement(OSWidgets$Image, {
extendedProperties: {
style: "font-size: 24px; height: 24px;"
},
gridProperties: {
width: "24px",
marginLeft: "0"
},
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.DashboardSlash.svg"),
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "6"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "OSInline"
},
visible: true,
_idProps: {
service: idService,
uuid: "7"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Link, {
enabled: true,
transition: OS$Transitions.createTransition(OS$Transitions.TransitionAnimation.Default),
url: OS$Navigation.generateScreenURL("ConectaProveedores", "Dashboard", {}),
visible: true,
_idProps: {
service: idService,
uuid: "8"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
style: "breadcrumb-before-page-link ",
text: [$text(getTranslation("SXicrpQHRkOc7oY8D+W76w#Value", "Dashboard"))],
_idProps: {
service: idService,
uuid: "9"
},
_widgetRecordProvider: widgetsRecordProvider
}))), createElement(OSWidgets$Image, {
extendedProperties: {
style: "font-size: 24px; height: 24px;"
},
gridProperties: {
width: "24px",
marginLeft: "0"
},
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.DashboardSlash.svg"),
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "10"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "OSInline"
},
visible: true,
_idProps: {
service: idService,
uuid: "11"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Link, {
enabled: true,
onClick: function () {
try {OS$Navigation.navigateBack(null, null, true);
} catch (ex) {
if(((ex.name) !== ("RedirectOccurredException"))) {
throw ex;
}

}
;
},
visible: true,
_idProps: {
service: idService,
uuid: "12"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
style: "breadcrumb-before-page-link",
text: [$text(getTranslation("0hfK3o2Ve0WTC46_Xz6mTw#Value", "Folios SAEC"))],
_idProps: {
service: idService,
uuid: "13"
},
_widgetRecordProvider: widgetsRecordProvider
}))), createElement(OSWidgets$Image, {
extendedProperties: {
style: "font-size: 24px; height: 24px;"
},
gridProperties: {
width: "24px",
marginLeft: "0"
},
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.DashboardSlash.svg"),
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "14"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "OSInline"
},
visible: true,
_idProps: {
service: idService,
uuid: "15"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
style: "breadcrumb-active",
text: [$text(getTranslation("08nxsA6jiU67JdFKT_ITpA#Value", "Form SAE Detail"))],
_idProps: {
service: idService,
uuid: "16"
},
_widgetRecordProvider: widgetsRecordProvider
})))];
}),
title: Widget.PlaceholderContent.Empty,
actions: Widget.PlaceholderContent.Empty,
mainContent: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "position-relative margin-bottom-base",
visible: true,
_idProps: {
service: idService,
uuid: "17"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
style: "display",
value: ((OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("HIB4jr+CxkOMbiFazFhCyQ#ValueExpression.68060425.1", "Folio") + " ") + model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.folioNumberAttr),
_idProps: {
service: idService,
uuid: "18"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioByIdAggr.dataFetchStatusAttr)
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "margin-right: 0px;"
},
gridProperties: {
classes: "OSInline ThemeGrid_MarginGutter"
},
style: "ContainerStatusTitle margin-auto",
visible: true,
_idProps: {
service: idService,
uuid: "19"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(model.variables.i_FolioIdIn.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier())), false, this, function () {
return [];
}, function () {
return [$if(model.variables.getFolioByIdAggr.isDataFetchedAttr, false, this, function () {
return [createElement(Telcel_Theme_Utils_Wb_Status_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_Class: model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioStatusAttr.classAttr,
_i_ClassInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioByIdAggr.dataFetchStatusAttr),
i_Text: model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioStatusAttr.labelAttr,
_i_TextInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioByIdAggr.dataFetchStatusAttr)
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
uuid: "20",
alias: "2"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "list-updating",
visible: true,
_idProps: {
service: idService,
uuid: "21"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})];
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width6 ThemeGrid_MarginGutter"
},
style: "position-absolute absolute-bottom-right text-align-right",
visible: true,
_idProps: {
service: idService,
uuid: "22"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if((model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).user_CreatedByAttr.nameAttr === ""), false, this, function () {
return [];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "text-align: right;"
},
gridProperties: {
classes: "ThemeGrid_Width6",
marginLeft: "0"
},
style: "ContainerStatusTitle ",
visible: true,
_idProps: {
service: idService,
uuid: "23"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "font-size: 12px; font-weight: normal;"
},
visible: true,
_idProps: {
service: idService,
uuid: "24"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
style: "text-secondary",
value: model.getCachedValue(idService.getId("+FMWlAwnC0q6tkTwzQXW4g.Value"), function () {
return ((((OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("q9ZmZGheikWJ4LD5FqyvUA#ValueExpression.-931882833.1", "Created by") + " ") + model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).user_CreatedByAttr.nameAttr) + ", ") + OS$BuiltinFunctions.formatDateTime(model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.createdOnAttr, "dd/MM/yyyy HH:mm"));
}, function () {
return model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).user_CreatedByAttr.nameAttr;
}, function () {
return model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.createdOnAttr;
}),
_idProps: {
service: idService,
uuid: "25"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioByIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: true,
extendedProperties: {
style: "font-size: 12px;"
},
visible: model.getCachedValue(idService.getId("xwaUzQ3ug06IJeCa2mocRA.Visible"), function () {
return ((model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.updatedByAttr) !== (OS$BuiltinFunctions.nullTextIdentifier()));
}, function () {
return model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.updatedByAttr;
}),
_idProps: {
service: idService,
uuid: "26"
},
_widgetRecordProvider: widgetsRecordProvider,
visible_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioByIdAggr.dataFetchStatusAttr)
}, createElement(OSWidgets$Expression, {
extendedProperties: {
style: "font-size: 12px; font-weight: normal;"
},
style: "text-secondary",
value: model.getCachedValue(idService.getId("3QrCKHC+00aGO2nX6DKIBQ.Value"), function () {
return ((((OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("1iuYmsOtrEeHaPX36AXjng#ValueExpression.1853933958.1", "Last updated by") + " ") + model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).user_UpdatedByAttr.nameAttr) + ", ") + OS$BuiltinFunctions.formatDateTime(model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.updatedOnAttr, "dd/MM/yyyy HH:mm"));
}, function () {
return model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).user_UpdatedByAttr.nameAttr;
}, function () {
return model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.updatedOnAttr;
}),
_idProps: {
service: idService,
uuid: "27"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioByIdAggr.dataFetchStatusAttr)
})))];
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: true,
style: "",
visible: model.getCachedValue(idService.getId("iNpUrdZLAkOc9pmQlVMocQ.Visible"), function () {
return (!(ConectaProveedoresController$default.checkProveedorRole$Action(callContext).hasRoleOut));
}),
_idProps: {
service: idService,
uuid: "28"
},
_widgetRecordProvider: widgetsRecordProvider
}))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-bottom-base",
visible: true,
_idProps: {
service: idService,
uuid: "29"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "30"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
style: "text-secondary",
value: model.getCachedValue(idService.getId("Zi5oNXGac02hPT1aZnLLBA.Value"), function () {
return ((model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).supplierAttr.nameAttr + ((((model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).supplierAttr.n_ident_fis_1Attr) !== (""))) ? (((" (" + model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).supplierAttr.n_ident_fis_1Attr) + ")")) : (""))) + ((((model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).supplierAttr.numberAttr) !== (""))) ? (((" (" + model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).supplierAttr.numberAttr) + ")")) : ("")));
}, function () {
return model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).supplierAttr.nameAttr;
}, function () {
return model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).supplierAttr.n_ident_fis_1Attr;
}, function () {
return model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).supplierAttr.numberAttr;
}),
_idProps: {
service: idService,
uuid: "31"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioByIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "32"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
style: "text-secondary",
value: ((model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).regionAttr.codeAttr + " ") + model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).regionAttr.divisionFIAttr),
_idProps: {
service: idService,
uuid: "33"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioByIdAggr.dataFetchStatusAttr)
}))), $if(model.variables.getFolioByIdAggr.isDataFetchedAttr, false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-bottom-base",
visible: true,
_idProps: {
service: idService,
uuid: "34"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if((((!(model.variables.getFolioByIdAggr.listOut.isEmpty)) && (!(ConectaProveedoresController$default.checkProveedorRole$Action(callContext).hasRoleOut))) && (!(model.variables.getFolioApprovalDisplayDataAct.folioApprovalDisplayListOut.isEmpty))), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "35"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(ConectaProveedores_y_Utils_Wb_TimelineUsersV2_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
StepList: model.getCachedValue(idService.getId("lSkrrZB29kCg9SDQNFzDcQ.StepList"), function () {
return OS$DataConversion.JSConversions.typeConvertRecordList(model.variables.getFolioApprovalDisplayDataAct.folioApprovalDisplayListOut, new (OS$GenericTypeCache.getGenericList(ST_f14441a8387aba6d017931caef70dd11Structure))(), function (source, target) {
target.orderAttr = source.levelNumberAttr;
target.labelAttr = source.nameAttr;
target.extendedClassAttr = (((source.approvalStatusIdAttr === ConectaProveedores_staticEntities_approvalStatus.notApproved)) ? ("inactive") : ((((source.approvalStatusIdAttr === ConectaProveedores_staticEntities_approvalStatus.approved)) ? ("approved1") : ((((source.approvalStatusIdAttr === ConectaProveedores_staticEntities_approvalStatus.rejected)) ? ("rejected1") : ((((source.approvalStatusIdAttr === ConectaProveedores_staticEntities_approvalStatus.canceled)) ? ("canceled1") : (((((source.approvalStatusIdAttr === ConectaProveedores_staticEntities_approvalStatus.evidenceRequested) || (source.approvalStatusIdAttr === ConectaProveedores_staticEntities_approvalStatus.evidenceReview))) ? ("rev1") : ("paid1"))))))))));
target.underLabelAttr = source.combinedJobTitlesAttr;
target.underLabelNCharAttr = 15;
return target;
});
}, function () {
return model.variables.getFolioApprovalDisplayDataAct.folioApprovalDisplayListOut;
}),
_stepListInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioApprovalDisplayDataAct.dataFetchStatusAttr)
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
uuid: "36",
alias: "3"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))];
}, function () {
return [];
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "card",
visible: true,
_idProps: {
service: idService,
uuid: "37"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(false, false, this, function () {
return [];
}, function () {
return [];
}), $if(((model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.folioStatusIdAttr === ConectaProveedores_staticEntities_folioStatus.incorrectInvoice) && ConectaProveedoresController$default.checkProveedorRole$Action(callContext).hasRoleOut), false, this, function () {
return [$if(model.variables.getFolioApprovalRejectReasonAggr.isDataFetchedAttr, false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-bottom-s vertical-align",
visible: true,
_idProps: {
service: idService,
uuid: "38"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Icon, {
extendedProperties: {
style: "color: #eb9100;"
},
icon: "exclamation-triangle",
iconSize: /*Twotimes*/ 1,
style: "icon",
visible: true,
_idProps: {
service: idService,
uuid: "39"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Expression, {
style: "margin-left-s",
value: model.variables.getFolioApprovalRejectReasonAggr.listOut.getCurrent(callContext.iterationContext).folioApprovalLevelAttr.rejectReasonAttr,
_idProps: {
service: idService,
uuid: "40"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioApprovalRejectReasonAggr.dataFetchStatusAttr)
}))];
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
})];
}, function () {
return [];
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "text-align-right margin-bottom-s",
visible: true,
_idProps: {
service: idService,
uuid: "42"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if((ConectaProveedoresController$default.checkProveedorRole$Action(callContext).hasRoleOut && model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.canProveedorCancelAttr), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "43"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Button, {
enabled: true,
isDefault: false,
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.openCloseCancelPopUp$Action(controller.callContext(eventHandlerContext));

;
},
style: "btn btn-cancel",
visible: model.getCachedValue(idService.getId("4Wlnf4jvsUmjknFFvwfstg.Visible"), function () {
return (ConectaProveedoresController$default.checkProveedorRole$Action(callContext).hasRoleOut && model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.canProveedorCancelAttr);
}, function () {
return model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.canProveedorCancelAttr;
}),
_idProps: {
service: idService,
uuid: "44"
},
_widgetRecordProvider: widgetsRecordProvider,
visible_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioByIdAggr.dataFetchStatusAttr)
}, $text(getTranslation("FzVeyx6fck275kAejzmjVg#Value", "Cancel")))), createElement(OSWidgets$Popup, {
showPopup: model.variables.showCancelPopupVar,
style: "popup-dialog",
_idProps: {
service: idService,
uuid: "45"
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
i_ConfirmationText: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("O2OrHe45l0WfHz3gp0C8Kg#Value.-791089077.1", "Are you sure you want to cancel the folio? This action is irreversible."),
i_PopupTitle: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("tnqJ8QaV3kqlGSL0gtiO4g#Value.1137498115.1", "Cancel Folio")
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
confirm$Action: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.cancelOnClick$Action(controller.callContext(eventHandlerContext));
});
;
},
close$Action: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.openCloseCancelPopUp$Action(controller.callContext(eventHandlerContext));

;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "46",
alias: "4"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))];
}, function () {
return [$if((!(ConectaProveedoresController$default.checkProveedorRole$Action(callContext).hasRoleOut)), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "47"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(ConectaProveedores_j_FoliosSAE_Wb_FolioActions_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_DirectReport: model.variables.i_IsDirectReportIn,
i_FolioId: model.variables.i_FolioIdIn
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
refresh$Action: function (i_IsOnlyHistoryIn, i_IsRedirectToFolioListIn, i_IsRedirectToFoliosRejectedIn, i_IsInvoiceApprovalIn) {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.wb_FormActionsRefresh$Action(i_IsOnlyHistoryIn, i_IsRedirectToFolioListIn, i_IsRedirectToFoliosRejectedIn, i_IsInvoiceApprovalIn, controller.callContext(eventHandlerContext));

;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "48",
alias: "5"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))];
}, function () {
return [];
})];
})), createElement(OutSystemsUI_Navigation_Tabs_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
OptionalConfigs: model.getCachedValue(idService.getId("Tabsss.OptionalConfigs"), function () {
return function () {
var rec = new ST_e3f9af4171d5e4a41700770295d05c77Structure();
rec.contentAutoHeightAttr = true;
rec.justifyHeadersAttr = true;
return rec;
}();
}),
TabsOrientation: ConectaProveedores_staticEntities_orientation.horizontal
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
name: "Tabsss",
alias: "6"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
header: new Widget.PlaceholderContent(function () {
return [createElement(OutSystemsUI_Navigation_TabsHeaderItem_mvc_view, {
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
uuid: "50",
alias: "7"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
title: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Text, {
style: "sub-heading ",
text: [$text(getTranslation("fV1Fd6TqoEeCWlMbkDHfKA#Value", "Overview"))],
_idProps: {
service: idService,
uuid: "51"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})
},
_dependencies: []
}), createElement(OutSystemsUI_Navigation_TabsHeaderItem_mvc_view, {
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
uuid: "52",
alias: "8"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
title: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "53"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
style: "sub-heading ",
text: [$text(getTranslation("dhvSnPmHzU+IiMA0Gmy09A#Value", "Positions"))],
_idProps: {
service: idService,
uuid: "54"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
})
},
_dependencies: []
}), $if((((model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.folioStatusIdAttr) !== (ConectaProveedores_staticEntities_folioStatus.canceled)) && ((model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.folioStatusIdAttr) !== (ConectaProveedores_staticEntities_folioStatus.canceledBySupplier))), false, this, function () {
return [createElement(OutSystemsUI_Navigation_TabsHeaderItem_mvc_view, {
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
uuid: "55",
alias: "9"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
title: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "text-align: left;"
},
visible: true,
_idProps: {
service: idService,
uuid: "56"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
style: "sub-heading ",
text: [$text(getTranslation("CmMuWW78ckSsXajryPYmlA#Value", "Folio Files"))],
_idProps: {
service: idService,
uuid: "57"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
})
},
_dependencies: []
})];
}, function () {
return [];
}), createElement(OutSystemsUI_Navigation_TabsHeaderItem_mvc_view, {
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
uuid: "58",
alias: "10"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
title: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "text-align: left;"
},
visible: true,
_idProps: {
service: idService,
uuid: "59"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
style: "sub-heading ",
text: [$text(getTranslation("DwMlIxwG9UanHl9LG_eTEQ#Value", "History"))],
_idProps: {
service: idService,
uuid: "60"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
})
},
_dependencies: []
}), $if((((((((((model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioStatusAttr.idAttr === ConectaProveedores_staticEntities_folioStatus.approved) || (model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioStatusAttr.idAttr === ConectaProveedores_staticEntities_folioStatus.failedEntryRequest)) || (model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioStatusAttr.idAttr === ConectaProveedores_staticEntities_folioStatus.pendingEntryRequest)) || (model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioStatusAttr.idAttr === ConectaProveedores_staticEntities_folioStatus.approvedWithoutInvoice)) || (model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioStatusAttr.idAttr === ConectaProveedores_staticEntities_folioStatus.contabilizationError)) || (model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioStatusAttr.idAttr === ConectaProveedores_staticEntities_folioStatus.contabilizationSuccess)) || (model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioStatusAttr.idAttr === ConectaProveedores_staticEntities_folioStatus.incorrectInvoice)) || (model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioStatusAttr.idAttr === ConectaProveedores_staticEntities_folioStatus.pendingApprovalAccounting)) && (model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.approvalProcessTypeIdAttr === ConectaProveedores_staticEntities_approvalProcessType.construction)), false, this, function () {
return [createElement(OutSystemsUI_Navigation_TabsHeaderItem_mvc_view, {
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
uuid: "61",
alias: "11"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
title: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "text-align: left;"
},
visible: true,
_idProps: {
service: idService,
uuid: "62"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
style: "sub-heading ",
text: [$text(getTranslation("KVj+n2QsJkSB6mv1jybvDA#Value", "Invoices"))],
_idProps: {
service: idService,
uuid: "63"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
})
},
_dependencies: []
})];
}, function () {
return [];
}), $if((((model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).supplierAttr.paisAttr) !== ("MX")) && model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioApprovalLevelAttr.isInvoiceApprovalAttr), false, this, function () {
return [createElement(OutSystemsUI_Navigation_TabsHeaderItem_mvc_view, {
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
uuid: "64",
alias: "12"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
title: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "text-align: left;"
},
visible: true,
_idProps: {
service: idService,
uuid: "65"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
style: "sub-heading ",
text: [$text(getTranslation("TFLrcvWfF0qmmlq+0IaTHg#Value", "Invoice Data"))],
_idProps: {
service: idService,
uuid: "66"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
})
},
_dependencies: []
})];
}, function () {
return [];
})];
}),
content: new Widget.PlaceholderContent(function () {
return [createElement(OutSystemsUI_Navigation_TabsContentItem_mvc_view, {
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
uuid: "67",
alias: "13"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [$if(model.variables.getUserApplicationRolesDataAct.isActiveDEV_DisenoUIOut, false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-base",
visible: true,
_idProps: {
service: idService,
uuid: "68"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(ConectaProveedores_j_FoliosSAE_Wb_SAECDetailMain_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
FolioDetailInfo: model.getCachedValue(idService.getId("QENpi27GkEeBNGHcsBh4vw.FolioDetailInfo"), function () {
return OS$DataConversion.JSConversions.typeConvertRecord(model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext), new ST_62dd5b695df6cdb1dddea5855e8718baStructure(), function (source, target) {
target.supplierNameAttr = source.supplierAttr.nameAttr;
target.supplierRFCAttr = source.supplierAttr.n_ident_fis_1Attr;
target.supplierNumberAttr = source.supplierAttr.numberAttr;
target.supplierRegionAttr = ((source.regionAttr.codeAttr + " ") + source.regionAttr.divisionFIAttr);
target.companyNameAttr = source.companyAttr.descriptionAttr;
target.orderNumberAttr = source.orderMainAttr.orderNumberAttr;
target.currencyCodeAttr = source.currencyAttr.codeAttr;
target.currencyTextAttr = source.currencyAttr.nameAttr;
target.creationDaysAttr = model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).dAYSOFCREATIONAttr;
target.totalAmountAttr = source.folioAttr.totalAmountAttr;
target.fluxAttr = model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).approvalProcessAttr.codeAttr;
target.fluxTypeAttr = model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).approvalProcessTypeAttr.label_ESAttr;
return target;
});
}, function () {
return model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext);
}),
_folioDetailInfoInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioByIdAggr.dataFetchStatusAttr)
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
uuid: "69",
alias: "14"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "text-align-center margin-top-xl",
visible: true,
_idProps: {
service: idService,
uuid: "70"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Button, {
enabled: true,
isDefault: false,
onClick: function () {
try {OS$Navigation.navigateBack(null, null, true);
} catch (ex) {
if(((ex.name) !== ("RedirectOccurredException"))) {
throw ex;
}

}
;
},
style: "btn btn-back white-space-nowrap",
visible: true,
_idProps: {
service: idService,
uuid: "71"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("BNt+kbv2mE2+3hg3jkIcow#Value", "Close")))))];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "height: 25px; text-align: right;"
},
style: "construction-badge margin-bottom-m",
visible: true,
_idProps: {
service: idService,
uuid: "72"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).approvalProcessTypeAttr.label_ESAttr,
_idProps: {
service: idService,
uuid: "73"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioByIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "74"
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
visible: true,
_idProps: {
service: idService,
name: "isReadOnly"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel",
visible: false,
_idProps: {
service: idService,
uuid: "77"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
targetWidget: "Input_FolioNumber",
_idProps: {
service: idService,
uuid: "78"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("nzh8HMX57Eq8n3lJwLeg8A#Value", "Folio Number"))), createElement(OSWidgets$Input, {
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
maxLength: 13,
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.folioNumberAttr, function (value) {
model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.folioNumberAttr = value;
}),
_idProps: {
service: idService,
name: "Input_FolioNumber"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioByIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "80"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OutSystemsUI_Adaptive_Columns2_mvc_view, {
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
validationService: validationService,
validationParentId: idService.getId("Form")
},
_idProps: {
service: idService,
uuid: "81",
alias: "15"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
column1: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel",
visible: true,
_idProps: {
service: idService,
uuid: "82"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: true,
targetWidget: "Input_OrderNumber",
_idProps: {
service: idService,
uuid: "83"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("KD8aAx2orUiqvaDdfc1Psg#Value", "Order"))), createElement(OSWidgets$Input, {
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
maxLength: 0,
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).orderMainAttr.orderNumberAttr, function (value) {
model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).orderMainAttr.orderNumberAttr = value;
}),
_idProps: {
service: idService,
name: "Input_OrderNumber"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioByIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel",
visible: true,
_idProps: {
service: idService,
uuid: "85"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: true,
targetWidget: "Input_Description",
_idProps: {
service: idService,
uuid: "86"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("WbuSD3LxuEOBZBnAumiidg#Value", "Company"))), createElement(OSWidgets$Input, {
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
maxLength: 0,
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).companyAttr.descriptionAttr, function (value) {
model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).companyAttr.descriptionAttr = value;
}),
_idProps: {
service: idService,
name: "Input_Description"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioByIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel",
visible: true,
_idProps: {
service: idService,
uuid: "88"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
targetWidget: "Input_TotalAmount",
_idProps: {
service: idService,
uuid: "89"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("6f1o6vbTyE+1sBNiLGA02Q#Value", "Total Amount"))), createElement(OutSystemsUI_Interaction_InputWithIcon_mvc_view, {
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
validationService: validationService,
validationParentId: idService.getId("Form")
},
_idProps: {
service: idService,
uuid: "90",
alias: "16"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
icon: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-left-s",
visible: false,
_idProps: {
service: idService,
uuid: "91"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).currencyAttr.codeAttr,
_idProps: {
service: idService,
uuid: "92"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioByIdAggr.dataFetchStatusAttr)
}))];
}),
input: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
enabled: false,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Number*/ 2,
mandatory: false,
maxLength: 37,
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Decimal, model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.totalAmountAttr, function (value) {
model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.totalAmountAttr = value;
}),
_idProps: {
service: idService,
name: "Input_TotalAmount"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioByIdAggr.dataFetchStatusAttr)
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.getFolioByIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.totalAmountAttr), asPrimitiveValue(model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).currencyAttr.codeAttr)]
}), createElement(InputMasks_InputMaskReactFlow_MaskCurrency_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
GroupSeparator: ",",
SuffixText: "",
PrefixText: "",
RightAlign: false,
DecimalDigits: OS$BuiltinFunctions.integerToDecimal(2),
AlwaysShowDecimalDigits: true,
UseNumericInput: true,
InputId: idService.getId("Input_TotalAmount"),
DecimalSeparator: "."
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
uuid: "94",
alias: "17"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))];
}),
column2: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel",
visible: false,
_idProps: {
service: idService,
uuid: "95"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: true,
targetWidget: "Input_Name",
_idProps: {
service: idService,
uuid: "96"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("dxwlAXG2jkeYo6CkN2_Omw#Value", "Supplier"))), createElement(OSWidgets$Input, {
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
maxLength: 0,
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).supplierAttr.nameAttr, function (value) {
model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).supplierAttr.nameAttr = value;
}),
_idProps: {
service: idService,
name: "Input_Name"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioByIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel",
visible: true,
_idProps: {
service: idService,
uuid: "98"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: true,
targetWidget: "Input_CurrencyName",
_idProps: {
service: idService,
uuid: "99"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("+dyknOoQ6Ue8eYsR01IPvw#Value", "Currency"))), createElement(OSWidgets$Input, {
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
maxLength: 0,
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).currencyAttr.nameAttr, function (value) {
model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).currencyAttr.nameAttr = value;
}),
_idProps: {
service: idService,
name: "Input_CurrencyName"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioByIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel",
visible: false,
_idProps: {
service: idService,
uuid: "101"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
targetWidget: "Input_TotalIVA_Amount",
_idProps: {
service: idService,
uuid: "102"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("c7PNFiRtsUCAKOajP0oVqg#Value", "Total IVA Amount"))), createElement(OutSystemsUI_Interaction_InputWithIcon_mvc_view, {
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
validationService: validationService,
validationParentId: idService.getId("Form")
},
_idProps: {
service: idService,
uuid: "103",
alias: "18"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
icon: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-left-s",
visible: true,
_idProps: {
service: idService,
uuid: "104"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).currencyAttr.codeAttr,
_idProps: {
service: idService,
uuid: "105"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioByIdAggr.dataFetchStatusAttr)
}))];
}),
input: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
enabled: false,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Number*/ 2,
mandatory: false,
maxLength: 37,
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Decimal, model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.totalIVA_AmountAttr, function (value) {
model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.totalIVA_AmountAttr = value;
}),
_idProps: {
service: idService,
name: "Input_TotalIVA_Amount"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioByIdAggr.dataFetchStatusAttr)
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.getFolioByIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.totalIVA_AmountAttr), asPrimitiveValue(model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).currencyAttr.codeAttr)]
}), createElement(InputMasks_InputMaskReactFlow_MaskCurrency_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
DecimalDigits: OS$BuiltinFunctions.integerToDecimal(2),
GroupSeparator: ",",
DecimalSeparator: ".",
UseNumericInput: true,
RightAlign: false,
InputId: idService.getId("Input_TotalIVA_Amount"),
SuffixText: "",
PrefixText: "",
AlwaysShowDecimalDigits: true
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
uuid: "107",
alias: "19"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))];
})
},
_dependencies: [asPrimitiveValue(model.variables.getFolioByIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).supplierAttr.nameAttr), asPrimitiveValue(model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.totalIVA_AmountAttr), asPrimitiveValue(model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.totalAmountAttr), asPrimitiveValue(model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).currencyAttr.nameAttr), asPrimitiveValue(model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).currencyAttr.codeAttr), asPrimitiveValue(model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).companyAttr.descriptionAttr), asPrimitiveValue(model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).orderMainAttr.orderNumberAttr)]
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-m",
visible: true,
_idProps: {
service: idService,
uuid: "108"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
extendedProperties: {
style: "font-weight: bold;"
},
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
targetWidget: "Input_TotalIVA_Amount",
_idProps: {
service: idService,
uuid: "109"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("3shcbxwij0yp4_iYcfNyNg#Value", "Comments and Observations"))), createElement(OSWidgets$List, {
animateItems: true,
gridProperties: {
classes: "OSFillParent"
},
mode: /*Default*/ 0,
source: model.variables.getFolioCommentsAggr.listOut,
style: "list list-group",
tag: "div",
_idProps: {
service: idService,
uuid: "110"
},
_widgetRecordProvider: widgetsRecordProvider,
source_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioCommentsAggr.dataFetchStatusAttr),
placeholders: {
content: new Widget.IteratorPlaceholderContent(function (idService, callContext) {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-s",
visible: true,
_idProps: {
service: idService,
uuid: "111"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getFolioCommentsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioCommentsAggr.listOut.getCurrent(callContext.iterationContext).folioObservationsAttr.createdOnAttr), asPrimitiveValue(model.variables.getFolioCommentsAggr.listOut.getCurrent(callContext.iterationContext).folioObservationsAttr.observationAttr)]
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "112"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.variables.getFolioCommentsAggr.listOut.getCurrent(callContext.iterationContext).folioObservationsAttr.observationAttr,
_idProps: {
service: idService,
uuid: "113"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioCommentsAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "color: #787b7e; font-size: 10px; text-align: right;"
},
visible: true,
_idProps: {
service: idService,
uuid: "114"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: OS$BuiltinFunctions.dateTimeToText(model.variables.getFolioCommentsAggr.listOut.getCurrent(callContext.iterationContext).folioObservationsAttr.createdOnAttr),
_idProps: {
service: idService,
uuid: "115"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioCommentsAggr.dataFetchStatusAttr)
})))];
}, callContext, idService, "1")
},
_dependencies: [asPrimitiveValue(model.variables.getFolioCommentsAggr.dataFetchStatusAttr)]
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel margin-top-m",
visible: true,
_idProps: {
service: idService,
uuid: "116"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OutSystemsUI_Adaptive_Columns2_mvc_view, {
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
validationService: validationService,
validationParentId: idService.getId("Form")
},
_idProps: {
service: idService,
uuid: "117",
alias: "20"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
column1: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel",
visible: true,
_idProps: {
service: idService,
uuid: "118"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: true,
targetWidget: "Input_OrderNumber2",
_idProps: {
service: idService,
uuid: "119"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("jNGvD8arQEWehLTnWk0xYw#Value", "Creation Date"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
enabled: false,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Datetime*/ 5,
mandatory: true,
maxLength: 0,
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.DateTime, model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.createdOnAttr, function (value) {
model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.createdOnAttr = value;
}),
_idProps: {
service: idService,
name: "Input_OrderNumber2"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioByIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel",
visible: true,
_idProps: {
service: idService,
uuid: "121"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: true,
targetWidget: "Input_OrderNumber4",
_idProps: {
service: idService,
uuid: "122"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("gyYwvezcx0eO_rSUcUGKmQ#Value", "Days Of Creation"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
enabled: false,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Number*/ 2,
mandatory: true,
maxLength: 0,
prompt: "0",
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Integer, model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).dAYSOFCREATIONAttr, function (value) {
model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).dAYSOFCREATIONAttr = value;
}),
_idProps: {
service: idService,
name: "Input_OrderNumber4"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioByIdAggr.dataFetchStatusAttr)
}))];
}),
column2: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel",
visible: true,
_idProps: {
service: idService,
uuid: "124"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: true,
targetWidget: "Input_OrderNumber3",
_idProps: {
service: idService,
uuid: "125"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("jxeINqgyBk28YAHfqpLgHA#Value", "Created By"))), createElement(OSWidgets$Input, {
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
maxLength: 0,
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).user_CreatedByAttr.nameAttr, function (value) {
model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).user_CreatedByAttr.nameAttr = value;
}),
_idProps: {
service: idService,
name: "Input_OrderNumber3"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioByIdAggr.dataFetchStatusAttr)
})), $if(((model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.approvalProcessTypeIdAttr) !== (OS$BuiltinFunctions.nullIdentifier())), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel",
visible: true,
_idProps: {
service: idService,
uuid: "127"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: true,
targetWidget: "Input_OrderNumber6",
_idProps: {
service: idService,
uuid: "128"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("tDd+CkGsSUehUR5fpsYf4Q#Value", "Flujo de acta"))), createElement(OSWidgets$Input, {
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
maxLength: 0,
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).approvalProcessAttr.codeAttr, function (value) {
model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).approvalProcessAttr.codeAttr = value;
}),
_idProps: {
service: idService,
name: "Input_OrderNumber6"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioByIdAggr.dataFetchStatusAttr)
}))];
}, function () {
return [$if(((model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).approvalProcessTypeAttr.idAttr) !== (OS$BuiltinFunctions.nullIdentifier())), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel",
visible: true,
_idProps: {
service: idService,
uuid: "130"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: true,
targetWidget: "Input_OrderNumber7",
_idProps: {
service: idService,
uuid: "131"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("hz3218bUBkuMvw2NZIvDyg#Value", "Flow Type"))), createElement(OSWidgets$Input, {
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
maxLength: 0,
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).approvalProcessTypeAttr.label_ESAttr, function (value) {
model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).approvalProcessTypeAttr.label_ESAttr = value;
}),
_idProps: {
service: idService,
name: "Input_OrderNumber7"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioByIdAggr.dataFetchStatusAttr)
}))];
}, function () {
return [];
})];
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.getFolioByIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).approvalProcessTypeAttr.label_ESAttr), asPrimitiveValue(model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).approvalProcessTypeAttr.idAttr), asPrimitiveValue(model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).approvalProcessAttr.codeAttr), asPrimitiveValue(model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).user_CreatedByAttr.nameAttr), asPrimitiveValue(model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).dAYSOFCREATIONAttr), asPrimitiveValue(model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.approvalProcessTypeIdAttr), asPrimitiveValue(model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.createdOnAttr)]
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel",
visible: true,
_idProps: {
service: idService,
uuid: "133"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OutSystemsUI_Adaptive_Columns2_mvc_view, {
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
validationService: validationService,
validationParentId: idService.getId("Form")
},
_idProps: {
service: idService,
uuid: "134",
alias: "21"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
column1: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel",
visible: true,
_idProps: {
service: idService,
uuid: "135"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
targetWidget: "Input_OrderNumber5",
_idProps: {
service: idService,
uuid: "136"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("+ChgoMOKxkWlEKjVpA9lZA#Value", "First Aprover"))), createElement(OSWidgets$Input, {
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
maxLength: 256,
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.getFirstApprovalAggr.listOut.getCurrent(callContext.iterationContext).userAttr.nameAttr, function (value) {
model.variables.getFirstApprovalAggr.listOut.getCurrent(callContext.iterationContext).userAttr.nameAttr = value;
}),
_idProps: {
service: idService,
name: "Input_OrderNumber5"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFirstApprovalAggr.dataFetchStatusAttr)
}))];
}),
column2: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel",
visible: true,
_idProps: {
service: idService,
uuid: "138"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
targetWidget: "Input_OrderNumber9",
_idProps: {
service: idService,
uuid: "139"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("t3xiR+kzcUmbekSeo6gqGQ#Value", "First Aprover Puesto"))), createElement(OSWidgets$Input, {
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
maxLength: 100,
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.getFirstApprovalAggr.listOut.getCurrent(callContext.iterationContext).entraRoleAttr.roleNameAttr, function (value) {
model.variables.getFirstApprovalAggr.listOut.getCurrent(callContext.iterationContext).entraRoleAttr.roleNameAttr = value;
}),
_idProps: {
service: idService,
name: "Input_OrderNumber9"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFirstApprovalAggr.dataFetchStatusAttr)
}))];
})
},
_dependencies: [asPrimitiveValue(model.variables.getFirstApprovalAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFirstApprovalAggr.listOut.getCurrent(callContext.iterationContext).entraRoleAttr.roleNameAttr), asPrimitiveValue(model.variables.getFirstApprovalAggr.listOut.getCurrent(callContext.iterationContext).userAttr.nameAttr)]
})), $if(false, false, this, function () {
return [];
}, function () {
return [];
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width6"
},
visible: true,
_idProps: {
service: idService,
uuid: "141"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Button, {
enabled: true,
isDefault: false,
onClick: function () {
try {OS$Navigation.navigateBack(null, null, true);
} catch (ex) {
if(((ex.name) !== ("RedirectOccurredException"))) {
throw ex;
}

}
;
},
style: "btn btn-back white-space-nowrap",
visible: true,
_idProps: {
service: idService,
uuid: "142"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("ULSd5zdMqki2n_9htJV1cg#Value", "Close"))))))];
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.getFirstApprovalAggr.listOut.getCurrent(callContext.iterationContext).entraRoleAttr.roleNameAttr), asPrimitiveValue(model.variables.getFirstApprovalAggr.listOut.getCurrent(callContext.iterationContext).userAttr.nameAttr), asPrimitiveValue(model.variables.getFolioCommentsAggr.listOut), asPrimitiveValue(model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext)), asPrimitiveValue(model.variables.getFirstApprovalAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioCommentsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioByIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getUserApplicationRolesDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getUserApplicationRolesDataAct.isActiveDEV_DisenoUIOut)]
}), createElement(OutSystemsUI_Navigation_TabsContentItem_mvc_view, {
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
uuid: "143",
alias: "22"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [$if(model.variables.getUserApplicationRolesDataAct.isActiveDEV_DisenoUIOut, false, this, function () {
return [createElement(ConectaProveedores_j_FoliosSAE_Wb_SAECDetailPositions_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_FolioId: model.variables.i_FolioIdIn,
i_CurrencyCode: model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).currencyAttr.codeAttr,
_i_CurrencyCodeInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioByIdAggr.dataFetchStatusAttr),
i_TotalAmount: model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.totalAmountAttr,
_i_TotalAmountInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioByIdAggr.dataFetchStatusAttr)
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
uuid: "144",
alias: "23"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
}, function () {
return [$if(model.variables.getFolioItemsByFolioIdAggr.listOut.isEmpty, false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "text-align-center",
visible: true,
_idProps: {
service: idService,
uuid: "145"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
style: "text-align-center",
value: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("wGoHuoFhmUixFZ3YAtZXbw#ValueExpression.1811764661.1", "There are no folio items associated with this folio"),
_idProps: {
service: idService,
uuid: "146"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
}, function () {
return [$if(model.variables.getFolioItemsByFolioIdAggr.isDataFetchedAttr, false, this, function () {
return [createElement(OutSystemsUI_Interaction_ScrollableArea_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
Orientation: ConectaProveedores_staticEntities_orientation.horizontal,
ScrollbarStyle: ConectaProveedores_staticEntities_scrollbarStyle.default
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
uuid: "147",
alias: "24"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$TableRecords, {
onSort: function (clickedColumnIn) {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.onSort$Action(clickedColumnIn, controller.callContext(eventHandlerContext));
});
;
},
showHeader: true,
source: model.variables.getFolioItemsByFolioIdAggr.listOut,
style: "table",
styleHeader: "table-header",
styleRow: "table-row",
_idProps: {
service: idService,
uuid: "148"
},
_widgetRecordProvider: widgetsRecordProvider,
source_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioItemsByFolioIdAggr.dataFetchStatusAttr),
placeholders: {
headerRow: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "width: 1%;"
},
_idProps: {
service: idService,
uuid: "149"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}), createElement(OSWidgets$HeaderCell, {
sortAttribute: "FolioItems.OrderNumber",
_idProps: {
service: idService,
uuid: "150"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("Q9iS_OeK4EWB7QbA4TWF2Q#Value", "Order Number"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: right"
},
sortAttribute: "OrderMainItem.Position",
_idProps: {
service: idService,
uuid: "151"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("URSW0+f5akWfwZebH9v6ZA#Value", "Position"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "FolioItems.ArticleNumber",
_idProps: {
service: idService,
uuid: "152"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("V9JnqMY8d0mhxEwB9X7pOQ#Value", "Article Number"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "FolioItems.InputationCode",
_idProps: {
service: idService,
uuid: "153"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("ujijDBqYDkuAg6eKunKe_A#Value", "Inputation Code"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "FolioItems.PEP",
style: model.getCachedValue(idService.getId("2_lqG_5j_0+Pqqnxh_SoyQ.Style"), function () {
return (((model.variables.getFolioItemsByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).folioItemsAttr.inputationCodeAttr === "Q")) ? ("") : ("display-none"));
}, function () {
return model.variables.getFolioItemsByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).folioItemsAttr.inputationCodeAttr;
}),
_idProps: {
service: idService,
uuid: "154"
},
_widgetRecordProvider: widgetsRecordProvider,
style_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioItemsByFolioIdAggr.dataFetchStatusAttr),
_dependencies: []
}, $text(getTranslation("XY9K3bG6JkeRMzIBrdTY0g#Value", "PEP Element"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "FolioItems.Description",
_idProps: {
service: idService,
uuid: "155"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("ZPGryaySDECGLnmyczQ9MQ#Value", "Description"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: right"
},
sortAttribute: "FolioItems.InvoiceQtt",
_idProps: {
service: idService,
uuid: "156"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("7HhqS7fk402DBB4ib8wt0Q#Value", "Invoice Qtt"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: right"
},
sortAttribute: "FolioItems.UnitPrice",
_idProps: {
service: idService,
uuid: "157"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("yuEfucZYAkaKj363DsQdaQ#Value", "Unit Price"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "FolioItems.TotalPrice",
_idProps: {
service: idService,
uuid: "158"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("756Qr0dWV0ar6ETABqLhPQ#Value", "Total Price"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: right"
},
sortAttribute: "FolioItems.DeliveryDate",
_idProps: {
service: idService,
uuid: "159"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("NNcCd4XPoE2damvDidYGlw#Value", "Delivery Date")))];
}),
row: new Widget.IteratorPlaceholderContent(function (idService, callContext) {
return [createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "160"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getFolioItemsByFolioIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioItemsByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).orderMainItemAttr.isMultipleImputationAttr)]
}, $if(model.variables.getFolioItemsByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).orderMainItemAttr.isMultipleImputationAttr, false, this, function () {
return [createElement(OutSystemsUI_Content_Tooltip_mvc_view, {
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
uuid: "161",
alias: "25"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Icon_mosaico.svg"),
style: "margin-right-s",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "162"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}),
tooltip: new Widget.PlaceholderContent(function () {
return ["Múltiple imputación"];
})
},
_dependencies: []
})];
}, function () {
return [];
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "163"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getFolioItemsByFolioIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioItemsByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).folioItemsAttr.orderNumberAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getFolioItemsByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).folioItemsAttr.orderNumberAttr,
_idProps: {
service: idService,
uuid: "164"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioItemsByFolioIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "165"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getFolioItemsByFolioIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioItemsByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).orderMainItemAttr.positionAttr)]
}, createElement(OSWidgets$Container, {
align: /*Right*/ 3,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "166"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: (model.variables.getFolioItemsByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).orderMainItemAttr.positionAttr).toString(),
_idProps: {
service: idService,
uuid: "167"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioItemsByFolioIdAggr.dataFetchStatusAttr)
}))), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "168"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getFolioItemsByFolioIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioItemsByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).folioItemsAttr.articleNumberAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getFolioItemsByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).folioItemsAttr.articleNumberAttr,
_idProps: {
service: idService,
uuid: "169"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioItemsByFolioIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "170"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getFolioItemsByFolioIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioItemsByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).folioItemsAttr.inputationCodeAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getFolioItemsByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).folioItemsAttr.inputationCodeAttr,
_idProps: {
service: idService,
uuid: "171"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioItemsByFolioIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
style: model.getCachedValue(idService.getId("iAue7aolyUyPpBq5MkLtQw.Style"), function () {
return (((model.variables.getFolioItemsByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).folioItemsAttr.inputationCodeAttr === "Q")) ? ("") : ("display-none"));
}, function () {
return model.variables.getFolioItemsByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).folioItemsAttr.inputationCodeAttr;
}),
_idProps: {
service: idService,
uuid: "172"
},
_widgetRecordProvider: widgetsRecordProvider,
style_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioItemsByFolioIdAggr.dataFetchStatusAttr),
_dependencies: [asPrimitiveValue(model.variables.getFolioItemsByFolioIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioItemsByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).folioItemsAttr.pEPAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getFolioItemsByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).folioItemsAttr.pEPAttr,
_idProps: {
service: idService,
uuid: "173"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioItemsByFolioIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "174"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getFolioItemsByFolioIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioItemsByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).folioItemsAttr.descriptionAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getFolioItemsByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).folioItemsAttr.descriptionAttr,
_idProps: {
service: idService,
uuid: "175"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioItemsByFolioIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "176"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getFolioItemsByFolioIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioItemsByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).folioItemsAttr.invoiceQttAttr)]
}, createElement(OSWidgets$Container, {
align: /*Right*/ 3,
animate: false,
extendedProperties: {
style: "text-align: center;"
},
style: "text-align-center",
visible: true,
_idProps: {
service: idService,
uuid: "177"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: OS$BuiltinFunctions.decimalToText(model.variables.getFolioItemsByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).folioItemsAttr.invoiceQttAttr),
_idProps: {
service: idService,
uuid: "178"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioItemsByFolioIdAggr.dataFetchStatusAttr)
}))), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "179"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getFolioItemsByFolioIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioItemsByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).folioItemsAttr.unitPriceAttr)]
}, createElement(OSWidgets$Container, {
align: /*Right*/ 3,
animate: false,
extendedProperties: {
style: "text-align: right;"
},
style: "text-align-center",
visible: true,
_idProps: {
service: idService,
uuid: "180"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("4dfS6Z5K+UiPd3Yx8bdNpQ.Value"), function () {
return OS$BuiltinFunctions.formatCurrency(model.variables.getFolioItemsByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).folioItemsAttr.unitPriceAttr, "", 2, ".", ",");
}, function () {
return model.variables.getFolioItemsByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).folioItemsAttr.unitPriceAttr;
}),
_idProps: {
service: idService,
uuid: "181"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioItemsByFolioIdAggr.dataFetchStatusAttr)
}))), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "182"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getFolioItemsByFolioIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioItemsByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).folioItemsAttr.totalPriceAttr)]
}, createElement(OSWidgets$Container, {
align: /*Right*/ 3,
animate: false,
extendedProperties: {
style: "text-align: right;"
},
style: "text-align-center",
visible: true,
_idProps: {
service: idService,
uuid: "183"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("YBnWMkk9E0qdZ3sMtmnJ0A.Value"), function () {
return OS$BuiltinFunctions.formatCurrency(model.variables.getFolioItemsByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).folioItemsAttr.totalPriceAttr, "", 2, ".", ",");
}, function () {
return model.variables.getFolioItemsByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).folioItemsAttr.totalPriceAttr;
}),
_idProps: {
service: idService,
uuid: "184"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioItemsByFolioIdAggr.dataFetchStatusAttr)
}))), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "185"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getFolioItemsByFolioIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioItemsByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).folioItemsAttr.deliveryDateAttr)]
}, createElement(OSWidgets$Container, {
align: /*Right*/ 3,
animate: false,
extendedProperties: {
style: "text-align: center;"
},
style: "text-align-center",
visible: true,
_idProps: {
service: idService,
uuid: "186"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("i_QSN6TmbkWxF+3At0Y+yw.Value"), function () {
return ((!(model.variables.getFolioItemsByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).folioItemsAttr.deliveryDateAttr.equals(OS$BuiltinFunctions.nullDate()))) ? (OS$BuiltinFunctions.dateToText(model.variables.getFolioItemsByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).folioItemsAttr.deliveryDateAttr)) : ("-"));
}, function () {
return model.variables.getFolioItemsByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).folioItemsAttr.deliveryDateAttr;
}),
_idProps: {
service: idService,
uuid: "187"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioItemsByFolioIdAggr.dataFetchStatusAttr)
})))];
}, callContext, idService, "2_0")
},
_dependencies: [asPrimitiveValue(model.variables.getFolioItemsByFolioIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioItemsByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).folioItemsAttr.inputationCodeAttr)]
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.getFolioItemsByFolioIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioItemsByFolioIdAggr.listOut)]
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width1 ThemeGrid_MarginGutter"
},
visible: true,
_idProps: {
service: idService,
name: "IsTableLoadingOrEmpty2"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if((model.variables.getFolioItemsByFolioIdAggr.isDataFetchedAttr && model.variables.getFolioItemsByFolioIdAggr.listOut.isEmpty), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "table-empty",
visible: true,
_idProps: {
service: idService,
uuid: "189"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("wQHVt52LJUuY2ibklOXA7A#Value", "No items to show...")))];
}, function () {
return [$if((!(model.variables.getFolioItemsByFolioIdAggr.isDataFetchedAttr)), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "list-updating",
visible: true,
_idProps: {
service: idService,
uuid: "190"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}, function () {
return [];
})];
})), createElement(OutSystemsUI_Navigation_Pagination_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
MaxRecords: model.variables.maxRecordsVar,
StartIndex: model.variables.startIndexVar,
TotalCount: model.variables.getFolioItemsByFolioIdAggr.countOut,
_totalCountInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioItemsByFolioIdAggr.dataFetchStatusAttr)
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
onNavigate$Action: function (newStartIndexIn) {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.onPaginationNavigate$Action(newStartIndexIn, controller.callContext(eventHandlerContext));
});
;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "191",
alias: "26"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
previous: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Icon, {
icon: "angle-left",
iconSize: /*FontSize*/ 0,
style: "icon",
visible: true,
_idProps: {
service: idService,
uuid: "192"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}),
next: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Icon, {
icon: "angle-right",
iconSize: /*FontSize*/ 0,
style: "icon",
visible: true,
_idProps: {
service: idService,
uuid: "193"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})
},
_dependencies: []
})];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "list-updating",
visible: true,
_idProps: {
service: idService,
uuid: "194"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})];
})];
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.startIndexVar), asPrimitiveValue(model.variables.maxRecordsVar), asPrimitiveValue(model.variables.getFolioItemsByFolioIdAggr.countOut), asPrimitiveValue(model.variables.getFolioItemsByFolioIdAggr.isDataFetchedAttr), asPrimitiveValue(model.variables.getFolioItemsByFolioIdAggr.listOut), asPrimitiveValue(model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.totalAmountAttr), asPrimitiveValue(model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).currencyAttr.codeAttr), asPrimitiveValue(model.variables.i_FolioIdIn), asPrimitiveValue(model.variables.getFolioItemsByFolioIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioByIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getUserApplicationRolesDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getUserApplicationRolesDataAct.isActiveDEV_DisenoUIOut)]
}), $if((((model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.folioStatusIdAttr) !== (ConectaProveedores_staticEntities_folioStatus.canceled)) && ((model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.folioStatusIdAttr) !== (ConectaProveedores_staticEntities_folioStatus.canceledBySupplier))), false, this, function () {
return [createElement(OutSystemsUI_Navigation_TabsContentItem_mvc_view, {
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
uuid: "195",
alias: "27"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "196"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(model.variables.getUserApplicationRolesDataAct.isActiveDEV_DisenoUIOut, false, this, function () {
return [createElement(ConectaProveedores_j_FoliosSAE_Wb_SAECFilesPreview_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_FolioId: model.variables.i_FolioIdIn,
i_FolioNumber: model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.folioNumberAttr,
_i_FolioNumberInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioByIdAggr.dataFetchStatusAttr)
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
refreshAfterUploadMoreEcidence$Action: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.wb_FolioFilesPreviewRefreshAfterUploadMoreEvidence$Action(controller.callContext(eventHandlerContext));

;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "197",
alias: "28"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
}, function () {
return [createElement(ConectaProveedores_j_FoliosSAE_Wb_FolioFilesPreview_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_FolioNumber: model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.folioNumberAttr,
_i_FolioNumberInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioByIdAggr.dataFetchStatusAttr),
i_FolioId: model.variables.i_FolioIdIn
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
refreshAfterUploadMoreEcidence$Action: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.wb_FolioFilesPreviewRefreshAfterUploadMoreEvidence$Action(controller.callContext(eventHandlerContext));

;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "198",
alias: "29"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
}))];
})
},
_dependencies: [asPrimitiveValue(model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.folioNumberAttr), asPrimitiveValue(model.variables.i_FolioIdIn), asPrimitiveValue(model.variables.getFolioByIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getUserApplicationRolesDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getUserApplicationRolesDataAct.isActiveDEV_DisenoUIOut)]
})];
}, function () {
return [];
}), createElement(OutSystemsUI_Navigation_TabsContentItem_mvc_view, {
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
uuid: "199",
alias: "30"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(ConectaProveedores_y_Logs_Wb_FolioLogs_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_FolioId: model.variables.i_FolioIdIn,
i_refresh: model.variables.l_RefreshOrderEntra_HistoricVar
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
uuid: "200",
alias: "31"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.l_RefreshOrderEntra_HistoricVar), asPrimitiveValue(model.variables.i_FolioIdIn)]
}), $if((((((((((model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioStatusAttr.idAttr === ConectaProveedores_staticEntities_folioStatus.approved) || (model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioStatusAttr.idAttr === ConectaProveedores_staticEntities_folioStatus.failedEntryRequest)) || (model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioStatusAttr.idAttr === ConectaProveedores_staticEntities_folioStatus.pendingEntryRequest)) || (model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioStatusAttr.idAttr === ConectaProveedores_staticEntities_folioStatus.approvedWithoutInvoice)) || (model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioStatusAttr.idAttr === ConectaProveedores_staticEntities_folioStatus.contabilizationError)) || (model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioStatusAttr.idAttr === ConectaProveedores_staticEntities_folioStatus.contabilizationSuccess)) || (model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioStatusAttr.idAttr === ConectaProveedores_staticEntities_folioStatus.incorrectInvoice)) || (model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioStatusAttr.idAttr === ConectaProveedores_staticEntities_folioStatus.pendingApprovalAccounting)) && (model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.approvalProcessTypeIdAttr === ConectaProveedores_staticEntities_approvalProcessType.construction)), false, this, function () {
return [createElement(OutSystemsUI_Navigation_TabsContentItem_mvc_view, {
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
uuid: "201",
alias: "32"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(ConectaProveedores_j_FoliosSAE_Wb_SAECInvoices_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_FolioId: model.variables.i_FolioIdIn,
IsReadOnly: false
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
refresh$Action: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.wb_SAECInvoicesRefresh$Action(controller.callContext(eventHandlerContext));

;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "202",
alias: "33"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.i_FolioIdIn)]
})];
}, function () {
return [];
}), $if((((model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).supplierAttr.paisAttr) !== ("MX")) && model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioApprovalLevelAttr.isInvoiceApprovalAttr), false, this, function () {
return [createElement(OutSystemsUI_Navigation_TabsContentItem_mvc_view, {
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
uuid: "203",
alias: "34"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "204"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(ConectaProveedores_j_FoliosSAE_Wb_ForeignSupplierInvoiceDetails_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_FolioId: model.variables.i_FolioIdIn
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
uuid: "205",
alias: "35"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))];
})
},
_dependencies: [asPrimitiveValue(model.variables.i_FolioIdIn)]
})];
}, function () {
return [];
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.l_RefreshOrderEntra_HistoricVar), asPrimitiveValue(model.variables.startIndexVar), asPrimitiveValue(model.variables.maxRecordsVar), asPrimitiveValue(model.variables.getFolioItemsByFolioIdAggr.countOut), asPrimitiveValue(model.variables.getFolioItemsByFolioIdAggr.isDataFetchedAttr), asPrimitiveValue(model.variables.getFolioItemsByFolioIdAggr.listOut), asPrimitiveValue(model.variables.i_FolioIdIn), asPrimitiveValue(model.variables.getFirstApprovalAggr.listOut.getCurrent(callContext.iterationContext).entraRoleAttr.roleNameAttr), asPrimitiveValue(model.variables.getFirstApprovalAggr.listOut.getCurrent(callContext.iterationContext).userAttr.nameAttr), asPrimitiveValue(model.variables.getFolioCommentsAggr.listOut), asPrimitiveValue(model.variables.getUserApplicationRolesDataAct.isActiveDEV_DisenoUIOut), asPrimitiveValue(model.variables.getFolioItemsByFolioIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFirstApprovalAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioCommentsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getUserApplicationRolesDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioByIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext))]
}))];
}, function () {
return [];
})];
}),
footer: Widget.PlaceholderContent.Empty
},
_dependencies: [asPrimitiveValue(model.variables.l_RefreshOrderEntra_HistoricVar), asPrimitiveValue(model.variables.startIndexVar), asPrimitiveValue(model.variables.maxRecordsVar), asPrimitiveValue(model.variables.getFolioItemsByFolioIdAggr.countOut), asPrimitiveValue(model.variables.getFolioItemsByFolioIdAggr.isDataFetchedAttr), asPrimitiveValue(model.variables.getFolioItemsByFolioIdAggr.listOut), asPrimitiveValue(model.variables.getFirstApprovalAggr.listOut.getCurrent(callContext.iterationContext).entraRoleAttr.roleNameAttr), asPrimitiveValue(model.variables.getFirstApprovalAggr.listOut.getCurrent(callContext.iterationContext).userAttr.nameAttr), asPrimitiveValue(model.variables.getFolioCommentsAggr.listOut), asPrimitiveValue(model.variables.getUserApplicationRolesDataAct.isActiveDEV_DisenoUIOut), asPrimitiveValue(model.variables.i_IsDirectReportIn), asPrimitiveValue(model.variables.showCancelPopupVar), asPrimitiveValue(model.variables.getFolioApprovalRejectReasonAggr.listOut.getCurrent(callContext.iterationContext).folioApprovalLevelAttr.rejectReasonAttr), asPrimitiveValue(model.variables.getFolioApprovalRejectReasonAggr.isDataFetchedAttr), asPrimitiveValue(model.variables.getFolioApprovalDisplayDataAct.folioApprovalDisplayListOut), asPrimitiveValue(model.variables.i_FolioIdIn), asPrimitiveValue(model.variables.getFolioItemsByFolioIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFirstApprovalAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioCommentsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getUserApplicationRolesDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioApprovalRejectReasonAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioApprovalDisplayDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioByIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioByIdAggr.isDataFetchedAttr), asPrimitiveValue(model.variables.getFolioByIdAggr.listOut.isEmpty), asPrimitiveValue(model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext))]
}));
}, {
topLevelComponent: true,
getAttributes: function () {
return {
codeFunction: "FolioSAE_Details",
functionKey: "064170fc-c683-4510-81de-b04dcbd2e71e",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "j_FoliosSAE.FolioSAE_Details",
modelFactory: ModelFactory,
controllerFactory: ControllerFactory,
getTitle: function (props) {
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
return ("Portal Conecta Proveedores " + ConectaProveedoresController$getEnviroment$Action(callContext).enviromentOut);
},
iconLibrary: ICON_LIBRARY_NAME,
iconMappings: ICON_MAPPINGS,
iconWeightMappings: WEIGHT_MAPPINGS,
iconSizeMappings: SIZE_MAPPINGS
});


ELEM.getCssDependencies = function () {
return ["css/font-awesome.min.css", "css/OutSystemsReactWidgets.css", "css/OutSystemsUI.OutSystemsUI.css", "css/Telcel_Theme.Telcel_Theme.css", "css/ConectaProveedores.j_FoliosSAE.FolioSAE_Details.css", "css/OutSystemsUI.OutSystemsUI.extra.css"];
};


ELEM.getJsDependencies = function () {
return [];
};


ELEM.getBlocks = function () {
return [ConectaProveedores_a_Layouts_LayoutTopMenu_mvc_view, Telcel_Theme_Utils_Wb_Status_mvc_view, ConectaProveedores_y_Utils_Wb_TimelineUsersV2_mvc_view, ConectaProveedores_y_Utils_Wb_ConfirmPopup_mvc_view, ConectaProveedores_j_FoliosSAE_Wb_FolioActions_mvc_view, OutSystemsUI_Navigation_Tabs_mvc_view, OutSystemsUI_Navigation_TabsHeaderItem_mvc_view, OutSystemsUI_Navigation_TabsContentItem_mvc_view, ConectaProveedores_j_FoliosSAE_Wb_SAECDetailMain_mvc_view, OutSystemsUI_Adaptive_Columns2_mvc_view, OutSystemsUI_Interaction_InputWithIcon_mvc_view, InputMasks_InputMaskReactFlow_MaskCurrency_mvc_view, ConectaProveedores_j_FoliosSAE_Wb_SAECDetailPositions_mvc_view, OutSystemsUI_Interaction_ScrollableArea_mvc_view, OutSystemsUI_Content_Tooltip_mvc_view, OutSystemsUI_Navigation_Pagination_mvc_view, ConectaProveedores_j_FoliosSAE_Wb_SAECFilesPreview_mvc_view, ConectaProveedores_j_FoliosSAE_Wb_FolioFilesPreview_mvc_view, ConectaProveedores_y_Logs_Wb_FolioLogs_mvc_view, ConectaProveedores_j_FoliosSAE_Wb_SAECInvoices_mvc_view, ConectaProveedores_j_FoliosSAE_Wb_ForeignSupplierInvoiceDetails_mvc_view];
};


return ELEM;
};

export default componentFactory()
