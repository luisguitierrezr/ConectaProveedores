namespace ssConectaProveedores {
/// <summary>
/// [Structure] AuditProposalsReportExportStruct (zTVfwb2320SBrc7Fli5LPQ)
///  <code>ST_003b164d236e27fa4a14d14a7514101cStructure</code> that represent
/// s <code>AuditProposalsReportExportStruct</code> <p>Description: Audit Proposals Report Export
///  Struct.</p>
/// </summary>
// Name: AuditProposalsReportExportStruct
public partial struct ST_003b164d236e27fa4a14d14a7514101cStructure : ITypedRecord<ST_003b164d236e27fa4a14d14a7514101cStructure> {
internal static readonly GlobalObjectKey IdSoc_ = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*dKl0ftRud0WV+LTYMqOiTg");
internal static readonly GlobalObjectKey IdRegion = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*mX+v7VmRVkubAyNNPQP1tw");
internal static readonly GlobalObjectKey IdDiv_ = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*bkNg9aG5_0aSThziiV5WtQ");
internal static readonly GlobalObjectKey IdRef = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*0oaujDHUMU2pNzexo36UFA");
internal static readonly GlobalObjectKey IdProposalName = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*KJ55vq42s0mao3rWaKjEUA");
internal static readonly GlobalObjectKey IdProposalType = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*gFeLkS37F0yXsDKWdv3mJw");
internal static readonly GlobalObjectKey IdProposalStatus = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*Z4ZCeUU6Qk6pmhLS5xFJfQ");
internal static readonly GlobalObjectKey IdPaymentDate = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*EjhRSP_5VEegIdhPJ4oZsQ");
internal static readonly GlobalObjectKey IdCuenta = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*20w9RV3MkE6+3SiYzc+IvQ");
internal static readonly GlobalObjectKey IdSupplierName = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*JhTjeXJgk06Lbewbas6Ofg");
internal static readonly GlobalObjectKey IdN_doc_ = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*HXWKX18bEUC0eX4pd38vZA");
internal static readonly GlobalObjectKey IdImporteenML = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*NLl2Mv36X0qktmdMuzG4AQ");
internal static readonly GlobalObjectKey IdML = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*uoChtd9dBky_Ing2lb589g");
internal static readonly GlobalObjectKey IdImporteenMD = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*HuouzVf9mESzxIxQ23jpzw");
internal static readonly GlobalObjectKey IdMD = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*9s2PnmGOQk2hMmVtnPqXSA");
internal static readonly GlobalObjectKey IdUpload = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*DIDod3_100GkxVoaU+mV_w");
internal static readonly GlobalObjectKey IdStatus = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*POMnRLeszEueYYVB1ojwWg");
internal static readonly GlobalObjectKey IdAppovedByUserLevel1 = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*hpeK73PYO0+OKSxI9m7GLQ");
internal static readonly GlobalObjectKey IdApprovedOnLevel1 = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*StcYfQZHR0WPJuEbN39l2g");
internal static readonly GlobalObjectKey IdAppovedByUserLevel2 = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*6tIQUElzpECJxFthVzYx_w");
internal static readonly GlobalObjectKey IdApprovedOnLevel2 = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*hz4Myo20iUaimSz__I_BSA");
internal static readonly GlobalObjectKey IdAppovedByUserLevel3 = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*qnQuEjdjKken38xBQMLFWQ");
internal static readonly GlobalObjectKey IdApprovedOnLevel3 = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*E7u5CUcRR0WTykRv3pPSMQ");
internal static readonly GlobalObjectKey IdTreasuryUser = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*XJhhi76LdUCnUupvCt4SoQ");
internal static readonly GlobalObjectKey IdPaidOn = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*APWdWzPRc0mlLhS+iigHxw");

public string ssSoc_;

public string ssRegion;

public string ssDiv_;

public string ssRef;

public string ssProposalName;

public string ssProposalType;

public string ssProposalStatus;

public DateTime ssPaymentDate;

public string ssCuenta;

public string ssSupplierName;

public string ssN_doc_;

public string ssImporteenML;

public string ssML;

public string ssImporteenMD;

public string ssMD;

public string ssUpload;

public string ssStatus;

public string ssAppovedByUserLevel1;

public string ssApprovedOnLevel1;

public string ssAppovedByUserLevel2;

public string ssApprovedOnLevel2;

public string ssAppovedByUserLevel3;

public string ssApprovedOnLevel3;

public string ssTreasuryUser;

public string ssPaidOn;


public BitArray OptimizedAttributes;

public ST_003b164d236e27fa4a14d14a7514101cStructure() {
OptimizedAttributes = null;
ssSoc_ = "";
ssRegion = "";
ssDiv_ = "";
ssRef = "";
ssProposalName = "";
ssProposalType = "";
ssProposalStatus = "";
ssPaymentDate = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
ssCuenta = "";
ssSupplierName = "";
ssN_doc_ = "";
ssImporteenML = "";
ssML = "";
ssImporteenMD = "";
ssMD = "";
ssUpload = "";
ssStatus = "";
ssAppovedByUserLevel1 = "";
ssApprovedOnLevel1 = "";
ssAppovedByUserLevel2 = "";
ssApprovedOnLevel2 = "";
ssAppovedByUserLevel3 = "";
ssApprovedOnLevel3 = "";
ssTreasuryUser = "";
ssPaidOn = "";
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[0];
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    }else{
    }
}
get{
    BitArray[] all = new BitArray[0];
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssSoc_ = r.ReadText(index++, "AuditProposalsReportExportStruct.Soc_", "");
ssRegion = r.ReadText(index++, "AuditProposalsReportExportStruct.Region", "");
ssDiv_ = r.ReadText(index++, "AuditProposalsReportExportStruct.Div_", "");
ssRef = r.ReadText(index++, "AuditProposalsReportExportStruct.Ref", "");
ssProposalName = r.ReadText(index++, "AuditProposalsReportExportStruct.ProposalName", "");
ssProposalType = r.ReadText(index++, "AuditProposalsReportExportStruct.ProposalType", "");
ssProposalStatus = r.ReadText(index++, "AuditProposalsReportExportStruct.ProposalStatus", "");
ssPaymentDate = r.ReadDate(index++, "AuditProposalsReportExportStruct.PaymentDate", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssCuenta = r.ReadText(index++, "AuditProposalsReportExportStruct.Cuenta", "");
ssSupplierName = r.ReadText(index++, "AuditProposalsReportExportStruct.SupplierName", "");
ssN_doc_ = r.ReadText(index++, "AuditProposalsReportExportStruct.N_doc_", "");
ssImporteenML = r.ReadText(index++, "AuditProposalsReportExportStruct.ImporteenML", "");
ssML = r.ReadText(index++, "AuditProposalsReportExportStruct.ML", "");
ssImporteenMD = r.ReadText(index++, "AuditProposalsReportExportStruct.ImporteenMD", "");
ssMD = r.ReadText(index++, "AuditProposalsReportExportStruct.MD", "");
ssUpload = r.ReadText(index++, "AuditProposalsReportExportStruct.Upload", "");
ssStatus = r.ReadText(index++, "AuditProposalsReportExportStruct.Status", "");
ssAppovedByUserLevel1 = r.ReadText(index++, "AuditProposalsReportExportStruct.AppovedByUserLevel1", "");
ssApprovedOnLevel1 = r.ReadText(index++, "AuditProposalsReportExportStruct.ApprovedOnLevel1", "");
ssAppovedByUserLevel2 = r.ReadText(index++, "AuditProposalsReportExportStruct.AppovedByUserLevel2", "");
ssApprovedOnLevel2 = r.ReadText(index++, "AuditProposalsReportExportStruct.ApprovedOnLevel2", "");
ssAppovedByUserLevel3 = r.ReadText(index++, "AuditProposalsReportExportStruct.AppovedByUserLevel3", "");
ssApprovedOnLevel3 = r.ReadText(index++, "AuditProposalsReportExportStruct.ApprovedOnLevel3", "");
ssTreasuryUser = r.ReadText(index++, "AuditProposalsReportExportStruct.TreasuryUser", "");
ssPaidOn = r.ReadText(index++, "AuditProposalsReportExportStruct.PaidOn", "");
}
/// <summary>
/// Read from database
/// </summary>
/// <param name="r"> Data reader</param>
public void ReadDB( DbDataReader r) {
int index = 0;
Read(r, ref index);
}

/// <summary>
/// Read from record
/// </summary>
/// <param name="r"> Record</param>
public void ReadIM(ST_003b164d236e27fa4a14d14a7514101cStructure r) {
this = r;
}


public static bool operator == (ST_003b164d236e27fa4a14d14a7514101cStructure a, ST_003b164d236e27fa4a14d14a7514101cStructure b) {
if (a.ssSoc_ != b.ssSoc_) return false;
if (a.ssRegion != b.ssRegion) return false;
if (a.ssDiv_ != b.ssDiv_) return false;
if (a.ssRef != b.ssRef) return false;
if (a.ssProposalName != b.ssProposalName) return false;
if (a.ssProposalType != b.ssProposalType) return false;
if (a.ssProposalStatus != b.ssProposalStatus) return false;
if (a.ssPaymentDate != b.ssPaymentDate) return false;
if (a.ssCuenta != b.ssCuenta) return false;
if (a.ssSupplierName != b.ssSupplierName) return false;
if (a.ssN_doc_ != b.ssN_doc_) return false;
if (a.ssImporteenML != b.ssImporteenML) return false;
if (a.ssML != b.ssML) return false;
if (a.ssImporteenMD != b.ssImporteenMD) return false;
if (a.ssMD != b.ssMD) return false;
if (a.ssUpload != b.ssUpload) return false;
if (a.ssStatus != b.ssStatus) return false;
if (a.ssAppovedByUserLevel1 != b.ssAppovedByUserLevel1) return false;
if (a.ssApprovedOnLevel1 != b.ssApprovedOnLevel1) return false;
if (a.ssAppovedByUserLevel2 != b.ssAppovedByUserLevel2) return false;
if (a.ssApprovedOnLevel2 != b.ssApprovedOnLevel2) return false;
if (a.ssAppovedByUserLevel3 != b.ssAppovedByUserLevel3) return false;
if (a.ssApprovedOnLevel3 != b.ssApprovedOnLevel3) return false;
if (a.ssTreasuryUser != b.ssTreasuryUser) return false;
if (a.ssPaidOn != b.ssPaidOn) return false;
return true;
}

public static bool operator != (ST_003b164d236e27fa4a14d14a7514101cStructure a, ST_003b164d236e27fa4a14d14a7514101cStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_003b164d236e27fa4a14d14a7514101cStructure)) return false;
return (this == (ST_003b164d236e27fa4a14d14a7514101cStructure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSoc_.GetHashCode()
 ^ ssRegion.GetHashCode()
 ^ ssDiv_.GetHashCode()
 ^ ssRef.GetHashCode()
 ^ ssProposalName.GetHashCode()
 ^ ssProposalType.GetHashCode()
 ^ ssProposalStatus.GetHashCode()
 ^ ssPaymentDate.GetHashCode()
 ^ ssCuenta.GetHashCode()
 ^ ssSupplierName.GetHashCode()
 ^ ssN_doc_.GetHashCode()
 ^ ssImporteenML.GetHashCode()
 ^ ssML.GetHashCode()
 ^ ssImporteenMD.GetHashCode()
 ^ ssMD.GetHashCode()
 ^ ssUpload.GetHashCode()
 ^ ssStatus.GetHashCode()
 ^ ssAppovedByUserLevel1.GetHashCode()
 ^ ssApprovedOnLevel1.GetHashCode()
 ^ ssAppovedByUserLevel2.GetHashCode()
 ^ ssApprovedOnLevel2.GetHashCode()
 ^ ssAppovedByUserLevel3.GetHashCode()
 ^ ssApprovedOnLevel3.GetHashCode()
 ^ ssTreasuryUser.GetHashCode()
 ^ ssPaidOn.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_003b164d236e27fa4a14d14a7514101cStructure Duplicate() {
ST_003b164d236e27fa4a14d14a7514101cStructure t;
t.ssSoc_ = this.ssSoc_;
t.ssRegion = this.ssRegion;
t.ssDiv_ = this.ssDiv_;
t.ssRef = this.ssRef;
t.ssProposalName = this.ssProposalName;
t.ssProposalType = this.ssProposalType;
t.ssProposalStatus = this.ssProposalStatus;
t.ssPaymentDate = this.ssPaymentDate;
t.ssCuenta = this.ssCuenta;
t.ssSupplierName = this.ssSupplierName;
t.ssN_doc_ = this.ssN_doc_;
t.ssImporteenML = this.ssImporteenML;
t.ssML = this.ssML;
t.ssImporteenMD = this.ssImporteenMD;
t.ssMD = this.ssMD;
t.ssUpload = this.ssUpload;
t.ssStatus = this.ssStatus;
t.ssAppovedByUserLevel1 = this.ssAppovedByUserLevel1;
t.ssApprovedOnLevel1 = this.ssApprovedOnLevel1;
t.ssAppovedByUserLevel2 = this.ssAppovedByUserLevel2;
t.ssApprovedOnLevel2 = this.ssApprovedOnLevel2;
t.ssAppovedByUserLevel3 = this.ssAppovedByUserLevel3;
t.ssApprovedOnLevel3 = this.ssApprovedOnLevel3;
t.ssTreasuryUser = this.ssTreasuryUser;
t.ssPaidOn = this.ssPaidOn;
t.OptimizedAttributes = null;
return t;
}

IRecord IRecord.Duplicate() {
return Duplicate();
}

public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
throw new System.InvalidOperationException();
}

public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
String head = VarValue.GetHead(fields);
String tail = VarValue.GetTail(fields);
variable.Found = false;
if (head == "soc_") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Soc_")) variable.Value = ssSoc_; else variable.Optimized = true;
} else if (head == "region") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Region")) variable.Value = ssRegion; else variable.Optimized = true;
} else if (head == "div_") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Div_")) variable.Value = ssDiv_; else variable.Optimized = true;
} else if (head == "ref") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Ref")) variable.Value = ssRef; else variable.Optimized = true;
} else if (head == "proposalname") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ProposalName")) variable.Value = ssProposalName; else variable.Optimized = true;
} else if (head == "proposaltype") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ProposalType")) variable.Value = ssProposalType; else variable.Optimized = true;
} else if (head == "proposalstatus") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ProposalStatus")) variable.Value = ssProposalStatus; else variable.Optimized = true;
} else if (head == "paymentdate") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PaymentDate")) variable.Value = ssPaymentDate; else variable.Optimized = true;
} else if (head == "cuenta") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Cuenta")) variable.Value = ssCuenta; else variable.Optimized = true;
} else if (head == "suppliername") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SupplierName")) variable.Value = ssSupplierName; else variable.Optimized = true;
} else if (head == "n_doc_") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".N_doc_")) variable.Value = ssN_doc_; else variable.Optimized = true;
} else if (head == "importeenml") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ImporteenML")) variable.Value = ssImporteenML; else variable.Optimized = true;
} else if (head == "ml") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ML")) variable.Value = ssML; else variable.Optimized = true;
} else if (head == "importeenmd") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ImporteenMD")) variable.Value = ssImporteenMD; else variable.Optimized = true;
} else if (head == "md") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".MD")) variable.Value = ssMD; else variable.Optimized = true;
} else if (head == "upload") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Upload")) variable.Value = ssUpload; else variable.Optimized = true;
} else if (head == "status") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Status")) variable.Value = ssStatus; else variable.Optimized = true;
} else if (head == "appovedbyuserlevel1") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".AppovedByUserLevel1")) variable.Value = ssAppovedByUserLevel1; else variable.Optimized = true;
} else if (head == "approvedonlevel1") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ApprovedOnLevel1")) variable.Value = ssApprovedOnLevel1; else variable.Optimized = true;
} else if (head == "appovedbyuserlevel2") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".AppovedByUserLevel2")) variable.Value = ssAppovedByUserLevel2; else variable.Optimized = true;
} else if (head == "approvedonlevel2") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ApprovedOnLevel2")) variable.Value = ssApprovedOnLevel2; else variable.Optimized = true;
} else if (head == "appovedbyuserlevel3") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".AppovedByUserLevel3")) variable.Value = ssAppovedByUserLevel3; else variable.Optimized = true;
} else if (head == "approvedonlevel3") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ApprovedOnLevel3")) variable.Value = ssApprovedOnLevel3; else variable.Optimized = true;
} else if (head == "treasuryuser") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TreasuryUser")) variable.Value = ssTreasuryUser; else variable.Optimized = true;
} else if (head == "paidon") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PaidOn")) variable.Value = ssPaidOn; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdSoc_) {
return ssSoc_;
}
if (key == IdRegion) {
return ssRegion;
}
if (key == IdDiv_) {
return ssDiv_;
}
if (key == IdRef) {
return ssRef;
}
if (key == IdProposalName) {
return ssProposalName;
}
if (key == IdProposalType) {
return ssProposalType;
}
if (key == IdProposalStatus) {
return ssProposalStatus;
}
if (key == IdPaymentDate) {
return ssPaymentDate;
}
if (key == IdCuenta) {
return ssCuenta;
}
if (key == IdSupplierName) {
return ssSupplierName;
}
if (key == IdN_doc_) {
return ssN_doc_;
}
if (key == IdImporteenML) {
return ssImporteenML;
}
if (key == IdML) {
return ssML;
}
if (key == IdImporteenMD) {
return ssImporteenMD;
}
if (key == IdMD) {
return ssMD;
}
if (key == IdUpload) {
return ssUpload;
}
if (key == IdStatus) {
return ssStatus;
}
if (key == IdAppovedByUserLevel1) {
return ssAppovedByUserLevel1;
}
if (key == IdApprovedOnLevel1) {
return ssApprovedOnLevel1;
}
if (key == IdAppovedByUserLevel2) {
return ssAppovedByUserLevel2;
}
if (key == IdApprovedOnLevel2) {
return ssApprovedOnLevel2;
}
if (key == IdAppovedByUserLevel3) {
return ssAppovedByUserLevel3;
}
if (key == IdApprovedOnLevel3) {
return ssApprovedOnLevel3;
}
if (key == IdTreasuryUser) {
return ssTreasuryUser;
}
if (key == IdPaidOn) {
return ssPaidOn;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdSoc_.Key.AsGuid) {
return ssSoc_;
}
if (attributeKey == IdRegion.Key.AsGuid) {
return ssRegion;
}
if (attributeKey == IdDiv_.Key.AsGuid) {
return ssDiv_;
}
if (attributeKey == IdRef.Key.AsGuid) {
return ssRef;
}
if (attributeKey == IdProposalName.Key.AsGuid) {
return ssProposalName;
}
if (attributeKey == IdProposalType.Key.AsGuid) {
return ssProposalType;
}
if (attributeKey == IdProposalStatus.Key.AsGuid) {
return ssProposalStatus;
}
if (attributeKey == IdPaymentDate.Key.AsGuid) {
return ssPaymentDate;
}
if (attributeKey == IdCuenta.Key.AsGuid) {
return ssCuenta;
}
if (attributeKey == IdSupplierName.Key.AsGuid) {
return ssSupplierName;
}
if (attributeKey == IdN_doc_.Key.AsGuid) {
return ssN_doc_;
}
if (attributeKey == IdImporteenML.Key.AsGuid) {
return ssImporteenML;
}
if (attributeKey == IdML.Key.AsGuid) {
return ssML;
}
if (attributeKey == IdImporteenMD.Key.AsGuid) {
return ssImporteenMD;
}
if (attributeKey == IdMD.Key.AsGuid) {
return ssMD;
}
if (attributeKey == IdUpload.Key.AsGuid) {
return ssUpload;
}
if (attributeKey == IdStatus.Key.AsGuid) {
return ssStatus;
}
if (attributeKey == IdAppovedByUserLevel1.Key.AsGuid) {
return ssAppovedByUserLevel1;
}
if (attributeKey == IdApprovedOnLevel1.Key.AsGuid) {
return ssApprovedOnLevel1;
}
if (attributeKey == IdAppovedByUserLevel2.Key.AsGuid) {
return ssAppovedByUserLevel2;
}
if (attributeKey == IdApprovedOnLevel2.Key.AsGuid) {
return ssApprovedOnLevel2;
}
if (attributeKey == IdAppovedByUserLevel3.Key.AsGuid) {
return ssAppovedByUserLevel3;
}
if (attributeKey == IdApprovedOnLevel3.Key.AsGuid) {
return ssApprovedOnLevel3;
}
if (attributeKey == IdTreasuryUser.Key.AsGuid) {
return ssTreasuryUser;
}
if (attributeKey == IdPaidOn.Key.AsGuid) {
return ssPaidOn;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSoc_ = (string) other.AttributeGet(IdSoc_);
ssRegion = (string) other.AttributeGet(IdRegion);
ssDiv_ = (string) other.AttributeGet(IdDiv_);
ssRef = (string) other.AttributeGet(IdRef);
ssProposalName = (string) other.AttributeGet(IdProposalName);
ssProposalType = (string) other.AttributeGet(IdProposalType);
ssProposalStatus = (string) other.AttributeGet(IdProposalStatus);
ssPaymentDate = (DateTime) other.AttributeGet(IdPaymentDate);
ssCuenta = (string) other.AttributeGet(IdCuenta);
ssSupplierName = (string) other.AttributeGet(IdSupplierName);
ssN_doc_ = (string) other.AttributeGet(IdN_doc_);
ssImporteenML = (string) other.AttributeGet(IdImporteenML);
ssML = (string) other.AttributeGet(IdML);
ssImporteenMD = (string) other.AttributeGet(IdImporteenMD);
ssMD = (string) other.AttributeGet(IdMD);
ssUpload = (string) other.AttributeGet(IdUpload);
ssStatus = (string) other.AttributeGet(IdStatus);
ssAppovedByUserLevel1 = (string) other.AttributeGet(IdAppovedByUserLevel1);
ssApprovedOnLevel1 = (string) other.AttributeGet(IdApprovedOnLevel1);
ssAppovedByUserLevel2 = (string) other.AttributeGet(IdAppovedByUserLevel2);
ssApprovedOnLevel2 = (string) other.AttributeGet(IdApprovedOnLevel2);
ssAppovedByUserLevel3 = (string) other.AttributeGet(IdAppovedByUserLevel3);
ssApprovedOnLevel3 = (string) other.AttributeGet(IdApprovedOnLevel3);
ssTreasuryUser = (string) other.AttributeGet(IdTreasuryUser);
ssPaidOn = (string) other.AttributeGet(IdPaidOn);
}
} // ST_003b164d236e27fa4a14d14a7514101cStructure
/// <summary>
/// RecordList type <code>AuditProposalsReportExportStructList</code> that represents a record list of
///  <code>AuditProposalsReportExportStruct</code>
/// </summary>
public partial class RL_70f17a16c6c90936793218dd5961800f : GenericRecordList<ST_003b164d236e27fa4a14d14a7514101cStructure>, IEnumerable, IEnumerator {

protected override ST_003b164d236e27fa4a14d14a7514101cStructure GetElementDefaultValue() {
return new ST_003b164d236e27fa4a14d14a7514101cStructure();
}

public T[] ToArray<T>(Func<ST_003b164d236e27fa4a14d14a7514101cStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_70f17a16c6c90936793218dd5961800f recordList, Func<ST_003b164d236e27fa4a14d14a7514101cStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_70f17a16c6c90936793218dd5961800f(ST_003b164d236e27fa4a14d14a7514101cStructure[] array) {
  RL_70f17a16c6c90936793218dd5961800f result = new RL_70f17a16c6c90936793218dd5961800f();
result.InnerFromArray(array);
    return result;
}

public static RL_70f17a16c6c90936793218dd5961800f ToList<T>(T[] array, Func <T, ST_003b164d236e27fa4a14d14a7514101cStructure> converter) {
  RL_70f17a16c6c90936793218dd5961800f result = new RL_70f17a16c6c90936793218dd5961800f();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_70f17a16c6c90936793218dd5961800f FromRestList<T>(RestList<T> restList, Func <T, ST_003b164d236e27fa4a14d14a7514101cStructure> converter) {
  RL_70f17a16c6c90936793218dd5961800f result = new RL_70f17a16c6c90936793218dd5961800f();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_70f17a16c6c90936793218dd5961800f() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_003b164d236e27fa4a14d14a7514101cStructure> NewList() {
return new RL_70f17a16c6c90936793218dd5961800f();
}


} // RL_70f17a16c6c90936793218dd5961800f
}

