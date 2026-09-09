namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (BaL8LXRUlkyfGncEg_JwLA)
///  <code>RC_db730a379abf48e3725f395a2176e12f</code> that represent
/// s
///  <code>RequisitionRequisitionApprovalLevelRequisitionApprovalRequisitionStatusShowCancelButtonCompan
/// ySupplierTelcelDirectionSegmentAccGroupPaymentTermsSegmentAccGroupTelcelDirRecord</code>
///  <p>Description: </p>
/// </summary>
// Name: RequisitionRequisitionApprovalLevelRequisitionApprovalRequisitionStatusShowCancelButtonCompanySupplierTelcelDirectionSegmentAccGroupPaymentTermsSegmentAccGroupTelcelDirRecord
public partial struct RC_db730a379abf48e3725f395a2176e12f : ITypedRecord<RC_db730a379abf48e3725f395a2176e12f> {
internal static readonly GlobalObjectKey IdRequisition = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*T3SBu1iqc67nzY23TLMhVQ");
internal static readonly GlobalObjectKey IdRequisitionApprovalLevel = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*jmkEVEb38DK8WXY1CdlRdw");
internal static readonly GlobalObjectKey IdRequisitionApproval = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*S+8rbTJ+TN58eIhu7_dSJA");
internal static readonly GlobalObjectKey IdRequisitionStatus = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*2VyosKSDP_TsIKnpR3QQSw");
internal static readonly GlobalObjectKey IdShowCancelButton = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*hqBtRaG_eMbT5GDgM+WQDg");
internal static readonly GlobalObjectKey IdCompany = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*bfqhmYH0W+wZCOdwyBtzsQ");
internal static readonly GlobalObjectKey IdSupplier = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*dOw0SWrcY4B7hMCYX1sSzg");
internal static readonly GlobalObjectKey IdTelcelDirection = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*GJPF90MHwEDiMLq9XqYvtQ");
internal static readonly GlobalObjectKey IdSegmentAccGroup = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*+b8blHMBdkkaN0lPzSFLmA");
internal static readonly GlobalObjectKey IdPaymentTerms = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*sbomVZepvUCHDd5qabo9mg");
internal static readonly GlobalObjectKey IdSegmentAccGroupTelcelDir = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*ld74eGfoyMweq7BUloy_Ww");

public EN_98680591dcf3728e0877a90eb5e1e552EntityRecord ssENRequisition;

public EN_27b1469f497d364a764a1359956ef9adEntityRecord ssENRequisitionApprovalLevel;

public EN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord ssENRequisitionApproval;

public EN_0554a1252840ba4a5c4e6af5899608adEntityRecord ssENRequisitionStatus;

public bool ssShowCancelButton;

public EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord ssENCompany;

public EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord ssENSupplier;

public EN_d466acc32a9bc0e97d052bc80d6c9d0bEntityRecord ssENTelcelDirection;

public EN_029f0fb77a2785e324319f171edbc2c0EntityRecord ssENSegmentAccGroup;

public EN_17720044fda96c0c2d8d0760c429f48aEntityRecord ssENPaymentTerms;

public EN_2a34dd0db0e0295f5091c15f08aa6001EntityRecord ssENSegmentAccGroupTelcelDir;


public BitArray OptimizedAttributes;

public RC_db730a379abf48e3725f395a2176e12f() {
OptimizedAttributes = null;
ssENRequisition = new EN_98680591dcf3728e0877a90eb5e1e552EntityRecord();
ssENRequisitionApprovalLevel = new EN_27b1469f497d364a764a1359956ef9adEntityRecord();
ssENRequisitionApproval = new EN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord();
ssENRequisitionStatus = new EN_0554a1252840ba4a5c4e6af5899608adEntityRecord();
ssShowCancelButton = false;
ssENCompany = new EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord();
ssENSupplier = new EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord();
ssENTelcelDirection = new EN_d466acc32a9bc0e97d052bc80d6c9d0bEntityRecord();
ssENSegmentAccGroup = new EN_029f0fb77a2785e324319f171edbc2c0EntityRecord();
ssENPaymentTerms = new EN_17720044fda96c0c2d8d0760c429f48aEntityRecord();
ssENSegmentAccGroupTelcelDir = new EN_2a34dd0db0e0295f5091c15f08aa6001EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[10];
    all[0] = new BitArray(58,false);
    all[1] = new BitArray(26,false);
    all[2] = new BitArray(10,false);
    all[3] = new BitArray(6,false);
    all[4] = new BitArray(11,false);
    all[5] = new BitArray(28,false);
    all[6] = new BitArray(7,false);
    all[7] = new BitArray(7,false);
    all[8] = new BitArray(11,false);
    all[9] = new BitArray(5,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENRequisition.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENRequisitionApprovalLevel.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENRequisitionApproval.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    ssENRequisitionStatus.OptimizedAttributes = GetDefaultOptimizedValues()[3];
    ssENCompany.OptimizedAttributes = GetDefaultOptimizedValues()[4];
    ssENSupplier.OptimizedAttributes = GetDefaultOptimizedValues()[5];
    ssENTelcelDirection.OptimizedAttributes = GetDefaultOptimizedValues()[6];
    ssENSegmentAccGroup.OptimizedAttributes = GetDefaultOptimizedValues()[7];
    ssENPaymentTerms.OptimizedAttributes = GetDefaultOptimizedValues()[8];
    ssENSegmentAccGroupTelcelDir.OptimizedAttributes = GetDefaultOptimizedValues()[9];
    }else{
    ssENRequisition.OptimizedAttributes = value[0];
    ssENRequisitionApprovalLevel.OptimizedAttributes = value[1];
    ssENRequisitionApproval.OptimizedAttributes = value[2];
    ssENRequisitionStatus.OptimizedAttributes = value[3];
    ssENCompany.OptimizedAttributes = value[4];
    ssENSupplier.OptimizedAttributes = value[5];
    ssENTelcelDirection.OptimizedAttributes = value[6];
    ssENSegmentAccGroup.OptimizedAttributes = value[7];
    ssENPaymentTerms.OptimizedAttributes = value[8];
    ssENSegmentAccGroupTelcelDir.OptimizedAttributes = value[9];
    }
}
get{
    BitArray[] all = new BitArray[10];
    all[0] = ssENRequisition.OptimizedAttributes;
    all[1] = ssENRequisitionApprovalLevel.OptimizedAttributes;
    all[2] = ssENRequisitionApproval.OptimizedAttributes;
    all[3] = ssENRequisitionStatus.OptimizedAttributes;
    all[4] = ssENCompany.OptimizedAttributes;
    all[5] = ssENSupplier.OptimizedAttributes;
    all[6] = ssENTelcelDirection.OptimizedAttributes;
    all[7] = ssENSegmentAccGroup.OptimizedAttributes;
    all[8] = ssENPaymentTerms.OptimizedAttributes;
    all[9] = ssENSegmentAccGroupTelcelDir.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENRequisition.Read( r, ref index);
ssENRequisitionApprovalLevel.Read( r, ref index);
ssENRequisitionApproval.Read( r, ref index);
ssENRequisitionStatus.Read( r, ref index);
ssShowCancelButton = r.ReadBoolean(index++, "RequisitionRequisitionApprovalLevelRequisitionApprovalRequisitionStatusShowCancelButtonCompanySupplierTelcelDirectionSegmentAccGroupPaymentTermsSegmentAccGroupTelcelDirRecord.ShowCancelButton", false);
ssENCompany.Read( r, ref index);
ssENSupplier.Read( r, ref index);
ssENTelcelDirection.Read( r, ref index);
ssENSegmentAccGroup.Read( r, ref index);
ssENPaymentTerms.Read( r, ref index);
ssENSegmentAccGroupTelcelDir.Read( r, ref index);
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
public void ReadIM(RC_db730a379abf48e3725f395a2176e12f r) {
this = r;
}


public static bool operator == (RC_db730a379abf48e3725f395a2176e12f a, RC_db730a379abf48e3725f395a2176e12f b) {
if (a.ssENRequisition != b.ssENRequisition) return false;
if (a.ssENRequisitionApprovalLevel != b.ssENRequisitionApprovalLevel) return false;
if (a.ssENRequisitionApproval != b.ssENRequisitionApproval) return false;
if (a.ssENRequisitionStatus != b.ssENRequisitionStatus) return false;
if (a.ssShowCancelButton != b.ssShowCancelButton) return false;
if (a.ssENCompany != b.ssENCompany) return false;
if (a.ssENSupplier != b.ssENSupplier) return false;
if (a.ssENTelcelDirection != b.ssENTelcelDirection) return false;
if (a.ssENSegmentAccGroup != b.ssENSegmentAccGroup) return false;
if (a.ssENPaymentTerms != b.ssENPaymentTerms) return false;
if (a.ssENSegmentAccGroupTelcelDir != b.ssENSegmentAccGroupTelcelDir) return false;
return true;
}

public static bool operator != (RC_db730a379abf48e3725f395a2176e12f a, RC_db730a379abf48e3725f395a2176e12f b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_db730a379abf48e3725f395a2176e12f)) return false;
return (this == (RC_db730a379abf48e3725f395a2176e12f)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENRequisition.GetHashCode()
 ^ ssENRequisitionApprovalLevel.GetHashCode()
 ^ ssENRequisitionApproval.GetHashCode()
 ^ ssENRequisitionStatus.GetHashCode()
 ^ ssShowCancelButton.GetHashCode()
 ^ ssENCompany.GetHashCode()
 ^ ssENSupplier.GetHashCode()
 ^ ssENTelcelDirection.GetHashCode()
 ^ ssENSegmentAccGroup.GetHashCode()
 ^ ssENPaymentTerms.GetHashCode()
 ^ ssENSegmentAccGroupTelcelDir.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENRequisition.RecursiveReset();
ssENRequisitionApprovalLevel.RecursiveReset();
ssENRequisitionApproval.RecursiveReset();
ssENRequisitionStatus.RecursiveReset();
ssENCompany.RecursiveReset();
ssENSupplier.RecursiveReset();
ssENTelcelDirection.RecursiveReset();
ssENSegmentAccGroup.RecursiveReset();
ssENPaymentTerms.RecursiveReset();
ssENSegmentAccGroupTelcelDir.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENRequisition.InternalRecursiveSave();
ssENRequisitionApprovalLevel.InternalRecursiveSave();
ssENRequisitionApproval.InternalRecursiveSave();
ssENRequisitionStatus.InternalRecursiveSave();
ssENCompany.InternalRecursiveSave();
ssENSupplier.InternalRecursiveSave();
ssENTelcelDirection.InternalRecursiveSave();
ssENSegmentAccGroup.InternalRecursiveSave();
ssENPaymentTerms.InternalRecursiveSave();
ssENSegmentAccGroupTelcelDir.InternalRecursiveSave();
}


public RC_db730a379abf48e3725f395a2176e12f Duplicate() {
RC_db730a379abf48e3725f395a2176e12f t;
t.ssENRequisition = (EN_98680591dcf3728e0877a90eb5e1e552EntityRecord)this.ssENRequisition.Duplicate();
t.ssENRequisitionApprovalLevel = (EN_27b1469f497d364a764a1359956ef9adEntityRecord)this.ssENRequisitionApprovalLevel.Duplicate();
t.ssENRequisitionApproval = (EN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord)this.ssENRequisitionApproval.Duplicate();
t.ssENRequisitionStatus = (EN_0554a1252840ba4a5c4e6af5899608adEntityRecord)this.ssENRequisitionStatus.Duplicate();
t.ssShowCancelButton = this.ssShowCancelButton;
t.ssENCompany = (EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord)this.ssENCompany.Duplicate();
t.ssENSupplier = (EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord)this.ssENSupplier.Duplicate();
t.ssENTelcelDirection = (EN_d466acc32a9bc0e97d052bc80d6c9d0bEntityRecord)this.ssENTelcelDirection.Duplicate();
t.ssENSegmentAccGroup = (EN_029f0fb77a2785e324319f171edbc2c0EntityRecord)this.ssENSegmentAccGroup.Duplicate();
t.ssENPaymentTerms = (EN_17720044fda96c0c2d8d0760c429f48aEntityRecord)this.ssENPaymentTerms.Duplicate();
t.ssENSegmentAccGroupTelcelDir = (EN_2a34dd0db0e0295f5091c15f08aa6001EntityRecord)this.ssENSegmentAccGroupTelcelDir.Duplicate();
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
if (head == "requisition") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Requisition")) variable.Value = ssENRequisition; else variable.Optimized = true;
variable.SetFieldName("requisition");
} else if (head == "requisitionapprovallevel") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RequisitionApprovalLevel")) variable.Value = ssENRequisitionApprovalLevel; else variable.Optimized = true;
variable.SetFieldName("requisitionapprovallevel");
} else if (head == "requisitionapproval") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RequisitionApproval")) variable.Value = ssENRequisitionApproval; else variable.Optimized = true;
variable.SetFieldName("requisitionapproval");
} else if (head == "requisitionstatus") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RequisitionStatus")) variable.Value = ssENRequisitionStatus; else variable.Optimized = true;
variable.SetFieldName("requisitionstatus");
} else if (head == "showcancelbutton") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ShowCancelButton")) variable.Value = ssShowCancelButton; else variable.Optimized = true;
} else if (head == "company") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Company")) variable.Value = ssENCompany; else variable.Optimized = true;
variable.SetFieldName("company");
} else if (head == "supplier") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Supplier")) variable.Value = ssENSupplier; else variable.Optimized = true;
variable.SetFieldName("supplier");
} else if (head == "telceldirection") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TelcelDirection")) variable.Value = ssENTelcelDirection; else variable.Optimized = true;
variable.SetFieldName("telceldirection");
} else if (head == "segmentaccgroup") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SegmentAccGroup")) variable.Value = ssENSegmentAccGroup; else variable.Optimized = true;
variable.SetFieldName("segmentaccgroup");
} else if (head == "paymentterms") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PaymentTerms")) variable.Value = ssENPaymentTerms; else variable.Optimized = true;
variable.SetFieldName("paymentterms");
} else if (head == "segmentaccgrouptelceldir") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SegmentAccGroupTelcelDir")) variable.Value = ssENSegmentAccGroupTelcelDir; else variable.Optimized = true;
variable.SetFieldName("segmentaccgrouptelceldir");
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
if (key == IdRequisition) {
return ssENRequisition;
}
if (key == IdRequisitionApprovalLevel) {
return ssENRequisitionApprovalLevel;
}
if (key == IdRequisitionApproval) {
return ssENRequisitionApproval;
}
if (key == IdRequisitionStatus) {
return ssENRequisitionStatus;
}
if (key == IdShowCancelButton) {
return ssShowCancelButton;
}
if (key == IdCompany) {
return ssENCompany;
}
if (key == IdSupplier) {
return ssENSupplier;
}
if (key == IdTelcelDirection) {
return ssENTelcelDirection;
}
if (key == IdSegmentAccGroup) {
return ssENSegmentAccGroup;
}
if (key == IdPaymentTerms) {
return ssENPaymentTerms;
}
if (key == IdSegmentAccGroupTelcelDir) {
return ssENSegmentAccGroupTelcelDir;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdRequisition.Key.AsGuid) {
return ssENRequisition;
}
if (attributeKey == IdRequisitionApprovalLevel.Key.AsGuid) {
return ssENRequisitionApprovalLevel;
}
if (attributeKey == IdRequisitionApproval.Key.AsGuid) {
return ssENRequisitionApproval;
}
if (attributeKey == IdRequisitionStatus.Key.AsGuid) {
return ssENRequisitionStatus;
}
if (attributeKey == IdShowCancelButton.Key.AsGuid) {
return ssShowCancelButton;
}
if (attributeKey == IdCompany.Key.AsGuid) {
return ssENCompany;
}
if (attributeKey == IdSupplier.Key.AsGuid) {
return ssENSupplier;
}
if (attributeKey == IdTelcelDirection.Key.AsGuid) {
return ssENTelcelDirection;
}
if (attributeKey == IdSegmentAccGroup.Key.AsGuid) {
return ssENSegmentAccGroup;
}
if (attributeKey == IdPaymentTerms.Key.AsGuid) {
return ssENPaymentTerms;
}
if (attributeKey == IdSegmentAccGroupTelcelDir.Key.AsGuid) {
return ssENSegmentAccGroupTelcelDir;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENRequisition.FillFromOther((IRecord) other.AttributeGet(IdRequisition));
ssENRequisitionApprovalLevel.FillFromOther((IRecord) other.AttributeGet(IdRequisitionApprovalLevel));
ssENRequisitionApproval.FillFromOther((IRecord) other.AttributeGet(IdRequisitionApproval));
ssENRequisitionStatus.FillFromOther((IRecord) other.AttributeGet(IdRequisitionStatus));
ssShowCancelButton = (bool) other.AttributeGet(IdShowCancelButton);
ssENCompany.FillFromOther((IRecord) other.AttributeGet(IdCompany));
ssENSupplier.FillFromOther((IRecord) other.AttributeGet(IdSupplier));
ssENTelcelDirection.FillFromOther((IRecord) other.AttributeGet(IdTelcelDirection));
ssENSegmentAccGroup.FillFromOther((IRecord) other.AttributeGet(IdSegmentAccGroup));
ssENPaymentTerms.FillFromOther((IRecord) other.AttributeGet(IdPaymentTerms));
ssENSegmentAccGroupTelcelDir.FillFromOther((IRecord) other.AttributeGet(IdSegmentAccGroupTelcelDir));
}
} // RC_db730a379abf48e3725f395a2176e12f
/// <summary>
/// RecordList type
///  <code>RequisitionRequisitionApprovalLevelRequisitionApprovalRequisitionStatusShowCancelButtonCompan
/// ySupplierTelcelDirectionSegmentAccGroupPaymentTermsSegmentAccGroupTelcelDirRecordList</code> that
///  represents a record list of <code>Requisition, RequisitionApprovalLevel, RequisitionApproval
/// , RequisitionStatus, Boolean, Company, Supplier, TelcelDirection, SegmentAccGroup, PaymentTerms,
///  SegmentAccGroupTelcelDir</code>
/// </summary>
public partial class RL_db407242f011e8b84a110f6970108663 : GenericRecordList<RC_db730a379abf48e3725f395a2176e12f>, IEnumerable, IEnumerator {

protected override RC_db730a379abf48e3725f395a2176e12f GetElementDefaultValue() {
return new RC_db730a379abf48e3725f395a2176e12f();
}

public T[] ToArray<T>(Func<RC_db730a379abf48e3725f395a2176e12f, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_db407242f011e8b84a110f6970108663 recordList, Func<RC_db730a379abf48e3725f395a2176e12f, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_db407242f011e8b84a110f6970108663(RC_db730a379abf48e3725f395a2176e12f[] array) {
  RL_db407242f011e8b84a110f6970108663 result = new RL_db407242f011e8b84a110f6970108663();
result.InnerFromArray(array);
    return result;
}

public static RL_db407242f011e8b84a110f6970108663 ToList<T>(T[] array, Func <T, RC_db730a379abf48e3725f395a2176e12f> converter) {
  RL_db407242f011e8b84a110f6970108663 result = new RL_db407242f011e8b84a110f6970108663();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_db407242f011e8b84a110f6970108663 FromRestList<T>(RestList<T> restList, Func <T, RC_db730a379abf48e3725f395a2176e12f> converter) {
  RL_db407242f011e8b84a110f6970108663 result = new RL_db407242f011e8b84a110f6970108663();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_db407242f011e8b84a110f6970108663() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[10];
def[0] = new BitArray(58,false);
def[1] = new BitArray(26,false);
def[2] = new BitArray(10,false);
def[3] = new BitArray(6,false);
def[4] = new BitArray(11,false);
def[5] = new BitArray(28,false);
def[6] = new BitArray(7,false);
def[7] = new BitArray(7,false);
def[8] = new BitArray(11,false);
def[9] = new BitArray(5,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_db730a379abf48e3725f395a2176e12f> NewList() {
return new RL_db407242f011e8b84a110f6970108663();
}


} // RL_db407242f011e8b84a110f6970108663
}

