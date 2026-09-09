namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (l1+DRAoWH0SMRmRcCnSE0w)
///  <code>RC_cc86cc41f7a6d52842bfa86c15f13d61</code> that represent
/// s
///  <code>RequisitionRequisitionAccountingAllFilesRequisitionAccConceptsi_RequisitionAccConcept_EstimEq
/// ualAgRecord</code> <p>Description: </p>
/// </summary>
// Name: RequisitionRequisitionAccountingAllFilesRequisitionAccConceptsi_RequisitionAccConcept_EstimEqualAgRecord
public partial struct RC_cc86cc41f7a6d52842bfa86c15f13d61 : ITypedRecord<RC_cc86cc41f7a6d52842bfa86c15f13d61> {
internal static readonly GlobalObjectKey IdRequisition = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*T3SBu1iqc67nzY23TLMhVQ");
internal static readonly GlobalObjectKey IdRequisitionAccounting = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*bnJgWEJBKbtzubqI0xdGXw");
internal static readonly GlobalObjectKey IdAllFiles = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*KqdTsstzCB2_m5J6zxgrQw");
internal static readonly GlobalObjectKey IdRequisitionAccConcepts = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*Nq1eS7GoBVPswfiWVWgYFg");
internal static readonly GlobalObjectKey Idi_RequisitionAccConcept_EstimEqualAg = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*fvzS_eYPlM4uirAf7XLUmA");

public EN_98680591dcf3728e0877a90eb5e1e552EntityRecord ssENRequisition;

public EN_3554712eb61e9f0a2132c551df0f1db5EntityRecord ssENRequisitionAccounting;

public RL_7a479a555821b093171c5d3cd3382006 ssRLAllFiles;

public RL_7c236018492d50b3625a5b0d981eb4eb ssRLRequisitionAccConcepts;

public RC_cdb29de40f41bea5403aac7edb2d6159 ssRCi_RequisitionAccConcept_EstimEqualAg;


public BitArray OptimizedAttributes;

public RC_cc86cc41f7a6d52842bfa86c15f13d61() {
OptimizedAttributes = null;
ssENRequisition = new EN_98680591dcf3728e0877a90eb5e1e552EntityRecord();
ssENRequisitionAccounting = new EN_3554712eb61e9f0a2132c551df0f1db5EntityRecord();
ssRLAllFiles = new RL_7a479a555821b093171c5d3cd3382006();
ssRLRequisitionAccConcepts = new RL_7c236018492d50b3625a5b0d981eb4eb();
ssRCi_RequisitionAccConcept_EstimEqualAg = new RC_cdb29de40f41bea5403aac7edb2d6159();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[3];
    all[0] = new BitArray(58,false);
    all[1] = new BitArray(19,false);
    all[2] = null;
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENRequisition.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENRequisitionAccounting.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    }else{
    ssENRequisition.OptimizedAttributes = value[0];
    ssENRequisitionAccounting.OptimizedAttributes = value[1];
    ssRCi_RequisitionAccConcept_EstimEqualAg.OptimizedAttributes = value[2];
    }
}
get{
    BitArray[] all = new BitArray[3];
    all[0] = ssENRequisition.OptimizedAttributes;
    all[1] = ssENRequisitionAccounting.OptimizedAttributes;
    all[2] = null;
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
ssENRequisitionAccounting.Read( r, ref index);
ssRCi_RequisitionAccConcept_EstimEqualAg.Read( r, ref index);
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
public void ReadIM(RC_cc86cc41f7a6d52842bfa86c15f13d61 r) {
this = r;
}


public static bool operator == (RC_cc86cc41f7a6d52842bfa86c15f13d61 a, RC_cc86cc41f7a6d52842bfa86c15f13d61 b) {
if (a.ssENRequisition != b.ssENRequisition) return false;
if (a.ssENRequisitionAccounting != b.ssENRequisitionAccounting) return false;
if (a.ssRLAllFiles != b.ssRLAllFiles) return false;
if (a.ssRLRequisitionAccConcepts != b.ssRLRequisitionAccConcepts) return false;
if (a.ssRCi_RequisitionAccConcept_EstimEqualAg != b.ssRCi_RequisitionAccConcept_EstimEqualAg) return false;
return true;
}

public static bool operator != (RC_cc86cc41f7a6d52842bfa86c15f13d61 a, RC_cc86cc41f7a6d52842bfa86c15f13d61 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_cc86cc41f7a6d52842bfa86c15f13d61)) return false;
return (this == (RC_cc86cc41f7a6d52842bfa86c15f13d61)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENRequisition.GetHashCode()
 ^ ssENRequisitionAccounting.GetHashCode()
 ^ ssRLAllFiles.GetHashCode()
 ^ ssRLRequisitionAccConcepts.GetHashCode()
 ^ ssRCi_RequisitionAccConcept_EstimEqualAg.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENRequisition.RecursiveReset();
ssENRequisitionAccounting.RecursiveReset();
ssRLAllFiles.RecursiveReset();
ssRLRequisitionAccConcepts.RecursiveReset();
ssRCi_RequisitionAccConcept_EstimEqualAg.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENRequisition.InternalRecursiveSave();
ssENRequisitionAccounting.InternalRecursiveSave();
ssRLAllFiles.InternalRecursiveSave();
ssRLRequisitionAccConcepts.InternalRecursiveSave();
ssRCi_RequisitionAccConcept_EstimEqualAg.InternalRecursiveSave();
}


public RC_cc86cc41f7a6d52842bfa86c15f13d61 Duplicate() {
RC_cc86cc41f7a6d52842bfa86c15f13d61 t;
t.ssENRequisition = (EN_98680591dcf3728e0877a90eb5e1e552EntityRecord)this.ssENRequisition.Duplicate();
t.ssENRequisitionAccounting = (EN_3554712eb61e9f0a2132c551df0f1db5EntityRecord)this.ssENRequisitionAccounting.Duplicate();
t.ssRLAllFiles = (RL_7a479a555821b093171c5d3cd3382006)this.ssRLAllFiles.Duplicate();
t.ssRLRequisitionAccConcepts = (RL_7c236018492d50b3625a5b0d981eb4eb)this.ssRLRequisitionAccConcepts.Duplicate();
t.ssRCi_RequisitionAccConcept_EstimEqualAg = (RC_cdb29de40f41bea5403aac7edb2d6159)this.ssRCi_RequisitionAccConcept_EstimEqualAg.Duplicate();
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
} else if (head == "requisitionaccounting") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RequisitionAccounting")) variable.Value = ssENRequisitionAccounting; else variable.Optimized = true;
variable.SetFieldName("requisitionaccounting");
} else if (head == "allfiles") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".AllFiles")) variable.Value = ssRLAllFiles; else variable.Optimized = true;
variable.SetFieldName("allfiles");
} else if (head == "requisitionaccconcepts") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RequisitionAccConcepts")) variable.Value = ssRLRequisitionAccConcepts; else variable.Optimized = true;
variable.SetFieldName("requisitionaccconcepts");
} else if (head == "i_requisitionaccconcept_estimequalag") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".i_RequisitionAccConcept_EstimEqualAg")) variable.Value = ssRCi_RequisitionAccConcept_EstimEqualAg; else variable.Optimized = true;
variable.SetFieldName("i_requisitionaccconcept_estimequalag");
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
if (key == IdRequisitionAccounting) {
return ssENRequisitionAccounting;
}
if (key == IdAllFiles) {
return ssRLAllFiles;
}
if (key == IdRequisitionAccConcepts) {
return ssRLRequisitionAccConcepts;
}
if (key == Idi_RequisitionAccConcept_EstimEqualAg) {
return ssRCi_RequisitionAccConcept_EstimEqualAg;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdRequisition.Key.AsGuid) {
return ssENRequisition;
}
if (attributeKey == IdRequisitionAccounting.Key.AsGuid) {
return ssENRequisitionAccounting;
}
if (attributeKey == IdAllFiles.Key.AsGuid) {
return ssRLAllFiles;
}
if (attributeKey == IdRequisitionAccConcepts.Key.AsGuid) {
return ssRLRequisitionAccConcepts;
}
if (attributeKey == Idi_RequisitionAccConcept_EstimEqualAg.Key.AsGuid) {
return ssRCi_RequisitionAccConcept_EstimEqualAg;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENRequisition.FillFromOther((IRecord) other.AttributeGet(IdRequisition));
ssENRequisitionAccounting.FillFromOther((IRecord) other.AttributeGet(IdRequisitionAccounting));
ssRLAllFiles = new RL_7a479a555821b093171c5d3cd3382006();
ssRLAllFiles.FillFromOther((IOSList) other.AttributeGet(IdAllFiles));
ssRLRequisitionAccConcepts = new RL_7c236018492d50b3625a5b0d981eb4eb();
ssRLRequisitionAccConcepts.FillFromOther((IOSList) other.AttributeGet(IdRequisitionAccConcepts));
ssRCi_RequisitionAccConcept_EstimEqualAg.FillFromOther((IRecord) other.AttributeGet(Idi_RequisitionAccConcept_EstimEqualAg));
}
} // RC_cc86cc41f7a6d52842bfa86c15f13d61
/// <summary>
/// RecordList type
///  <code>RequisitionRequisitionAccountingAllFilesRequisitionAccConceptsi_RequisitionAccConcept_EstimEq
/// ualAgRecordList</code> that represents a record list of <code>Requisition, RequisitionAccounting,
///  RequisitionFileTypesStructList, RequisitionAccConceptsAccountingDataTypeRecordList
/// , MainAccConceptSubAccConceptsRecord</code>
/// </summary>
public partial class RL_39c32a40fc4b4770e91055f94db26813 : GenericRecordList<RC_cc86cc41f7a6d52842bfa86c15f13d61>, IEnumerable, IEnumerator {

protected override RC_cc86cc41f7a6d52842bfa86c15f13d61 GetElementDefaultValue() {
return new RC_cc86cc41f7a6d52842bfa86c15f13d61();
}

public T[] ToArray<T>(Func<RC_cc86cc41f7a6d52842bfa86c15f13d61, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_39c32a40fc4b4770e91055f94db26813 recordList, Func<RC_cc86cc41f7a6d52842bfa86c15f13d61, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_39c32a40fc4b4770e91055f94db26813(RC_cc86cc41f7a6d52842bfa86c15f13d61[] array) {
  RL_39c32a40fc4b4770e91055f94db26813 result = new RL_39c32a40fc4b4770e91055f94db26813();
result.InnerFromArray(array);
    return result;
}

public static RL_39c32a40fc4b4770e91055f94db26813 ToList<T>(T[] array, Func <T, RC_cc86cc41f7a6d52842bfa86c15f13d61> converter) {
  RL_39c32a40fc4b4770e91055f94db26813 result = new RL_39c32a40fc4b4770e91055f94db26813();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_39c32a40fc4b4770e91055f94db26813 FromRestList<T>(RestList<T> restList, Func <T, RC_cc86cc41f7a6d52842bfa86c15f13d61> converter) {
  RL_39c32a40fc4b4770e91055f94db26813 result = new RL_39c32a40fc4b4770e91055f94db26813();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_39c32a40fc4b4770e91055f94db26813() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[3];
def[0] = new BitArray(58,false);
def[1] = new BitArray(19,false);
def[2] = null;
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_cc86cc41f7a6d52842bfa86c15f13d61> NewList() {
return new RL_39c32a40fc4b4770e91055f94db26813();
}


} // RL_39c32a40fc4b4770e91055f94db26813
}

