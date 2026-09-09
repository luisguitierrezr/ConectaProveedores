import { BuiltinFunctions as OS$BuiltinFunctions } from "@outsystems/runtime-core-js";

export var SE_orderStatus = Object.freeze({
get canceled() {return 11;
},
get inApproval() {return 5;
},
get approved() {return 7;
},
get approvalRejected() {return 9;
},
get unreleased() {return 13;
},
get modify() {return 12;
},
get toComplement() {return 1;
},
get deleted() {return 14;
},
get inInformationCompletion() {return 3;
},
get rejected() {return 4;
},
get released() {return 10;
},
get errorAPI() {return 8;
}
});


export var SE_folioStatus = Object.freeze({
get evidenceReview() {return 1;
},
get approved() {return 4;
},
get failedEntryRequest() {return 6;
},
get evidenceRequested() {return 2;
},
get pendingApproval() {return 3;
},
get canceled() {return 5;
},
get failedExitRequest() {return 7;
},
get pendingEntryRequest() {return 8;
},
get contabilizationSuccess() {return 12;
},
get incorrectInvoice() {return 15;
},
get pendingApprovalAccounting() {return 14;
},
get approvedWithoutInvoice() {return 10;
},
get canceledBySupplier() {return 9;
},
get contabilizationError() {return 11;
}
});


export var SE_orderRetentionType = Object.freeze({
get percent25() {return 3;
},
get percent10() {return 1;
},
get other() {return 4;
}
});


export var SE_contractFileType = Object.freeze({
get deposit() {return 2;
},
get contractPendingJustification() {return 7;
},
get proofOfForeignResidence() {return 6;
},
get insurance() {return 3;
},
get advancePayment() {return 4;
},
get contract() {return 1;
},
get rEPSE() {return 8;
},
get financeAuthorization() {return 5;
},
get exchangeRateEvidence() {return 9;
}
});


export var SE_invoiceStatus = Object.freeze({
get pendingAccounting() {return 17;
},
get submitted_FRONTENDPORPUSES() {return 11;
},
get modify() {return 9;
},
get pendingPayment() {return 7;
},
get approved() {return 10;
},
get inApproval_UserArea() {return 3;
},
get documentUpload() {return 1;
},
get assignInitialApprover() {return 2;
},
get scheduledForPayment() {return 5;
},
get rejected() {return 12;
},
get canceled() {return 6;
},
get manualAccounting() {return 18;
},
get contabilizationError() {return 13;
},
get paid() {return 8;
},
get contabilizationSuccess() {return 14;
},
get inApproval_CxP() {return 4;
},
get accounting() {return 15;
}
});


export var SE_proposalType = Object.freeze({
get lease() {return 2;
},
get comission() {return 1;
}
});


export var SE_orderMainItemStatus = Object.freeze({
get deleted() {return 4;
},
get notDelivered() {return 1;
},
get blocked() {return 5;
},
get delivered() {return 3;
},
get partiallyDelivered() {return 2;
}
});


export var SE_commentType = Object.freeze({
get observation() {return 2;
},
get modify() {return 5;
},
get reject() {return 1;
},
get evidenceRequest() {return 6;
},
get notPaid() {return 3;
},
get cancel() {return 4;
}
});


export var SE_approvalStatus = Object.freeze({
get rejected() {return 3;
},
get assigned() {return 23;
},
get paid() {return 6;
},
get evidenceReview() {return 28;
},
get complemented() {return 26;
},
get toComplement() {return 24;
},
get notApproved() {return 21;
},
get toAssign() {return 22;
},
get evidenceRequested() {return 27;
},
get inInformationCompletion() {return 25;
},
get canceled() {return 8;
},
get errorAPI() {return 4;
},
get notPaid() {return 7;
},
get pending() {return 10;
},
get approved() {return 2;
},
get modify() {return 9;
}
});


export var SE_invoiceTaxType = Object.freeze({
get retencion() {return 2;
},
get traslado() {return 1;
}
});


export var SE_contractStatus = Object.freeze({
get pending() {return 3;
},
get no() {return 2;
},
get yes() {return 1;
}
});


export var SE_logsAccountingSubject = Object.freeze({
get offset() {return 13;
},
get orderRequest() {return 7;
},
get retentions() {return 2;
},
get xMLValidations() {return 1;
},
get contaFaturas() {return 8;
},
get errorEntry06May() {return 12;
},
get aPINotify() {return 9;
},
get aPIUpdate() {return 10;
},
get amountRequisitions() {return 11;
},
get pAC() {return 4;
},
get tipoCambio() {return 6;
},
get entries() {return 5;
},
get accounting() {return 3;
}
});


export var SE_proposalStatus = Object.freeze({
get errorAPI() {return 7;
},
get canceled() {return 6;
},
get approved() {return 1;
},
get beingPaid() {return 9;
},
get inApproval() {return 3;
},
get paid() {return 5;
},
get partiallyPaid() {return 10;
},
get rejected() {return 4;
}
});


export var SE_invoiceAccountingProcessStatus = Object.freeze({
get ongoing() {return 2;
},
get finished() {return 3;
},
get pending() {return 1;
}
});


export var SE_requisitionStatus = Object.freeze({
get dataCapture() {return 1;
},
get canceled() {return 4;
},
get accounting() {return 10;
},
get approved() {return 3;
},
get inApproval() {return 2;
},
get modify() {return 7;
},
get expired() {return 6;
}
});


export var SE_specialApproval = Object.freeze({
get applies() {return 1;
},
get notApplicable() {return 2;
}
});


export var SE_importStatus = Object.freeze({
get import() {return 2;
},
get distribute() {return 3;
},
get sendEmail() {return 6;
},
get done() {return 5;
},
get new() {return 1;
},
get error() {return 4;
}
});


export var SE_aIContentType = Object.freeze({
get textContent() {return OS$BuiltinFunctions.integerToLongInteger(1);
},
get imageURL() {return OS$BuiltinFunctions.integerToLongInteger(2);
},
get imageBinary() {return OS$BuiltinFunctions.integerToLongInteger(3);
}
});


export var SE_aIRole = Object.freeze({
get system() {return OS$BuiltinFunctions.integerToLongInteger(1);
},
get user() {return OS$BuiltinFunctions.integerToLongInteger(2);
},
get assistant() {return OS$BuiltinFunctions.integerToLongInteger(3);
},
get action() {return OS$BuiltinFunctions.integerToLongInteger(4);
}
});


export var SE_seriesType = Object.freeze({
get lineSpline() {return "spline";
},
get pie() {return "pie";
},
get column() {return "column";
},
get area() {return "area";
},
get line() {return "line";
},
get areaSpline() {return "areaspline";
},
get bar() {return "bar";
}
});


export var SE_legendPosition = Object.freeze({
get bottom() {return "Bottom";
},
get right() {return "Right";
},
get center() {return "Center";
},
get bottomRight() {return "BottomRight";
},
get left() {return "Left";
},
get top() {return "Top";
},
get topLeft() {return "TopLeft";
},
get topRight() {return "TopRight";
},
get bottomLeft() {return "BottomLeft";
}
});


export var SE_legendLayout = Object.freeze({
get proximate() {return "proximate";
},
get horizontal() {return "horizontal";
},
get vertical() {return "vertical";
}
});


export var SE_operator = Object.freeze({
get lessThan() {return "<";
},
get equal() {return "=";
},
get greaterThan() {return ">";
}
});


export var SE_currency = Object.freeze({
get gBP() {return "GBP";
},
get eUR() {return "EUR";
},
get mXN() {return "MXN";
},
get uSD() {return "USD";
}
});


export var SE_dayOfWeek = Object.freeze({
get wednesday() {return 4;
},
get tuesday() {return 3;
},
get friday() {return 6;
},
get saturday() {return 7;
},
get monday() {return 2;
},
get thursday() {return 5;
},
get sunday() {return 1;
}
});


export var SE_processStatus = Object.freeze({
get active() {return OS$BuiltinFunctions.integerToLongInteger(1);
},
get activeWithErrors() {return OS$BuiltinFunctions.integerToLongInteger(2);
},
get terminated() {return OS$BuiltinFunctions.integerToLongInteger(4);
},
get done() {return OS$BuiltinFunctions.integerToLongInteger(3);
}
});


export var SE_activityStatus = Object.freeze({
get running() {return OS$BuiltinFunctions.integerToLongInteger(2);
},
get terminated() {return OS$BuiltinFunctions.integerToLongInteger(4);
},
get waiting() {return OS$BuiltinFunctions.integerToLongInteger(1);
},
get open() {return OS$BuiltinFunctions.integerToLongInteger(6);
},
get error() {return OS$BuiltinFunctions.integerToLongInteger(5);
},
get completed() {return OS$BuiltinFunctions.integerToLongInteger(3);
}
});


export var SE_activityKind = Object.freeze({
get terminate() {return OS$BuiltinFunctions.integerToLongInteger(8);
},
get end() {return OS$BuiltinFunctions.integerToLongInteger(5);
},
get conditionalStart() {return OS$BuiltinFunctions.integerToLongInteger(6);
},
get wait() {return OS$BuiltinFunctions.integerToLongInteger(7);
},
get decision() {return OS$BuiltinFunctions.integerToLongInteger(4);
},
get humanActivity() {return OS$BuiltinFunctions.integerToLongInteger(3);
},
get automaticActivity() {return OS$BuiltinFunctions.integerToLongInteger(2);
},
get start() {return OS$BuiltinFunctions.integerToLongInteger(1);
}
});


export var SE_marginSize = Object.freeze({
get oneTopBottomByOnePointTwentyFiveSides_in() {return "2.54x3.17x2.54x3.17";
},
get onePointFive_cm() {return "1.50x1.50x1.50x1.50";
},
get twoPointFive_cm() {return "2.50x2.50x2.50x2.50";
},
get noMargin() {return "0.00x0.00x0.00x0.00";
},
get one_in() {return "2.54x2.54x2.54x2.54";
},
get one_cm() {return "1.00x1.00x1.00x1.00";
},
get twoPointFiveTopBottomByThreeSides_cm() {return "2.50x3.00x2.50x3.00";
}
});


export var SE_paperSize = Object.freeze({
get landscapeA5() {return "21.00x14.80";
},
get landscapeA4() {return "29.70x21.00";
},
get letter() {return "21.59x27.94";
},
get legal() {return "21.59x35.56";
},
get landscapeLetter() {return "27.94x21.59";
},
get a4() {return "21.00x29.70";
},
get executive() {return "18.41x26.67";
},
get a5() {return "14.80x21.00";
},
get landscapeLegal() {return "35.56x21.59";
},
get landscapeExecutive() {return "26.67x18.41";
}
});


export var SE_origin = Object.freeze({
get screenAccessWebApp() {return 3;
},
get createAction() {return 4;
},
get orderDistributionConfig() {return 1;
},
get screenAccess() {return 2;
},
get downloadAction() {return 7;
},
get editAction() {return 5;
},
get deleteAction() {return 6;
}
});


export var SE_sideMenuBehavior = Object.freeze({
get visible() {return "aside-visible";
},
get expandable() {return "aside-expandable";
},
get overlay() {return "aside-overlay";
}
});


export var SE_size = Object.freeze({
get medium() {return "medium";
},
get small() {return "small";
}
});


export var SE_gutterSize = Object.freeze({
get xXLarge() {return "gutter-xxl";
},
get medium() {return "gutter-m";
},
get none() {return "gutter-none";
},
get extraLarge() {return "gutter-xl";
},
get small() {return "gutter-s";
},
get large() {return "gutter-l";
},
get base() {return "gutter-base";
},
get extraSmall() {return "gutter-xs";
}
});


export var SE_orientation = Object.freeze({
get horizontal() {return "horizontal";
},
get vertical() {return "vertical";
}
});


export var SE_datePickerTimeFormat = Object.freeze({
get disabled() {return "disabled";
},
get time24hFormat() {return "24";
},
get time12hFormat() {return "12";
}
});


export var SE_accordionIconType = Object.freeze({
get custom() {return "Custom";
},
get plusMinus() {return "PlusMinus";
},
get caret() {return "Caret";
}
});


export var SE_direction = Object.freeze({
get left() {return "left";
},
get right() {return "right";
}
});


export var SE_breakColumns = Object.freeze({
get none() {return "break-none";
},
get first() {return "break-first";
},
get all() {return "break-all";
},
get middle() {return "break-middle";
},
get last() {return "break-last";
}
});


export var SE_shape = Object.freeze({
get sharp() {return "none";
},
get softRounded() {return "soft";
},
get rounded() {return "rounded";
}
});


export var SE_position = Object.freeze({
get top() {return "top";
},
get left() {return "left";
},
get bottomRight() {return "bottom-right";
},
get bottomLeft() {return "bottom-left";
},
get right() {return "right";
},
get topLeft() {return "top-left";
},
get topRight() {return "top-right";
},
get center() {return "center";
},
get bottom() {return "bottom";
}
});


export var SE_trigger = Object.freeze({
get onClick() {return "onclick";
},
get onHover() {return "onhover";
}
});


export var SE_space = Object.freeze({
get large() {return "l";
},
get medium() {return "m";
},
get xXLarge() {return "xxl";
},
get extraSmall() {return "xs";
},
get small() {return "s";
},
get base() {return "base";
},
get extraLarge() {return "xl";
},
get none() {return "none";
}
});


export var SE_booleanTypes = Object.freeze({
get true() {return "true";
},
get unset() {return "unset";
},
get false() {return "false";
}
});


export var SE_accordionIconPosition = Object.freeze({
get left() {return "left";
},
get right() {return "right";
}
});


export var SE_scrollbarStyle = Object.freeze({
get none() {return "none";
},
get default() {return "default";
},
get compact() {return "compact";
}
});


export var SE_color = Object.freeze({
get neutral9() {return "neutral-9";
},
get grape() {return "grape";
},
get neutral7() {return "neutral-7";
},
get neutral10() {return "neutral-10";
},
get teal() {return "teal";
},
get primary() {return "primary";
},
get neutral4() {return "neutral-4";
},
get neutral8() {return "neutral-8";
},
get indigo() {return "indigo";
},
get orange() {return "orange";
},
get lime() {return "lime";
},
get cyan() {return "cyan";
},
get secondary() {return "secondary";
},
get neutral6() {return "neutral-6";
},
get yellow() {return "yellow";
},
get neutral2() {return "neutral-2";
},
get neutral1() {return "neutral-1";
},
get neutral3() {return "neutral-3";
},
get transparent() {return "transparent";
},
get violet() {return "violet";
},
get blue() {return "blue";
},
get neutral5() {return "neutral-5";
},
get red() {return "red";
},
get pink() {return "pink";
},
get green() {return "green";
},
get neutral0() {return "neutral-0";
}
});


export var SE_steps = Object.freeze({
get next() {return "next";
},
get past() {return "past";
},
get active() {return "active";
}
});


export var SE_videoState = Object.freeze({
get unstarted() {return "Unstarted";
},
get paused() {return "Paused";
},
get ended() {return "Ended";
},
get playing() {return "Playing";
}
});


export var SE_datePickerWeekDay = Object.freeze({
get monday() {return 1;
},
get saturday() {return 6;
},
get sunday() {return 0;
},
get friday() {return 5;
},
get tuesday() {return 2;
},
get thursday() {return 4;
},
get wednesday() {return 3;
}
});


export var SE_concept = Object.freeze({
get fcP() {return 2;
},
get fsP() {return 3;
},
get cyA() {return 1;
}
});


export var SE_roleStatus = Object.freeze({
get toBeActive() {return 1;
},
get revoked() {return 3;
},
get expired() {return 4;
},
get active() {return 2;
}
});


export var SE_internalConcept = Object.freeze({
get marketing() {return 2;
},
get conectaProveedores() {return 1;
}
});


export var SE_depositType = Object.freeze({
get advancePayment() {return 1;
},
get compliance() {return 2;
},
get hiddenDefects() {return 3;
}
});


export var SE_accountingDataType = Object.freeze({
get estimation() {return 1;
},
get settlement() {return 4;
},
get equalization() {return 2;
},
get anticipo() {return 8;
},
get estim_Equal_Agreed() {return 7;
},
get agreedPayments() {return 3;
},
get creditNote() {return 5;
},
get voucher() {return 6;
}
});


export var SE_insuranceType = Object.freeze({
get other() {return 4;
},
get damage() {return 1;
},
get allRisks() {return 3;
},
get civilLiability() {return 2;
}
});


export var SE_customSettings = Object.freeze({
get foreignerCurrencyMargin() {return 3;
},
get sessionTimeout() {return 5;
},
get accountingIndicatorDBCRSmaller() {return 8;
},
get accountingGLAccountBigger() {return 9;
},
get accountingGLAccountSmaller() {return 10;
},
get sessionWarning() {return 4;
},
get accountingIndicatorDBCRBigger() {return 7;
},
get uploadContractDateLimit() {return 1;
},
get constructionMargin() {return 6;
},
get nationalCurrencyMargin() {return 2;
}
});


export var SE_cFDIType = Object.freeze({
get finiquito() {return 3;
},
get notadecredito() {return 4;
},
get anticipo() {return 1;
},
get factura() {return 5;
},
get estimacion() {return 2;
}
});


export var SE_distribution = Object.freeze({
get variable() {return 2;
},
get fixed() {return 1;
}
});


export var SE_approvalProcessType = Object.freeze({
get alternative() {return 3;
},
get normal() {return 4;
},
get special() {return 2;
},
get construction() {return 1;
}
});


export var SE_specialPostDeliveryAuthorization = Object.freeze({
get afterDeliveryToWarehouse() {return 2;
},
get beforeDeliveryToWarehouse() {return 1;
}
});


export var SE_frequency = Object.freeze({
get bimonthly() {return 4;
},
get anual() {return 1;
},
get semestral() {return 2;
},
get monthly() {return 5;
},
get weekly() {return 7;
},
get perEvent() {return 8;
},
get trimestral() {return 3;
},
get biweekly() {return 6;
}
});


export var SE_appConcept = Object.freeze({
get marketing() {return 2;
},
get conecta() {return 1;
}
});


export var SE_userArea = Object.freeze({
get areaCxP() {return 2;
},
get areaUsuaria() {return 1;
},
get proveedor() {return 3;
}
});


export var SE_advancePaymentType = Object.freeze({
get withInvoice() {return 1;
},
get withoutInvoice() {return 2;
}
});


export var SE_entraDomain = Object.freeze({
get telcel() {return 1;
},
get americaMovel() {return 2;
}
});



