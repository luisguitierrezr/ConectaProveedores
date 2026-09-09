namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (BsliQL5IG0esiNLjGJz8xg)
///  <code>RC_44742d4360afdf16ff97b37b2eff1760</code> that represent
/// s
///  <code>RequisitionRequisitionAccountingAllFilesRequisitionAccConceptsRecordListRequisitionCostCenter
/// sRequisitionServicesi_RequisitionAccConcept_EstimEqualAgRecord</code> <p>Description: </p>
/// </summary>
// Name: RequisitionRequisitionAccountingAllFilesRequisitionAccConceptsRecordListRequisitionCostCentersRequisitionServicesi_RequisitionAccConcept_EstimEqualAgRecord
public partial struct RC_44742d4360afdf16ff97b37b2eff1760 : ITypedRecord<RC_44742d4360afdf16ff97b37b2eff1760> {
internal static readonly GlobalObjectKey IdRequisition = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*T3SBu1iqc67nzY23TLMhVQ");
internal static readonly GlobalObjectKey IdRequisitionAccounting = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*bnJgWEJBKbtzubqI0xdGXw");
internal static readonly GlobalObjectKey IdAllFiles = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*KqdTsstzCB2_m5J6zxgrQw");
internal static readonly GlobalObjectKey IdRequisitionAccConceptsRecordList = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*YrlpVAL0dHjc7jAFawPsrg");
internal static readonly GlobalObjectKey IdRequisitionCostCenters = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*GmENxDzIWM6ef2yYk6G2kA");
internal static readonly GlobalObjectKey IdRequisitionServices = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*5UaPB4WZSrM5bKHwoDbXvw");
internal static readonly GlobalObjectKey Idi_RequisitionAccConcept_EstimEqualAg = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*fvzS_eYPlM4uirAf7XLUmA");

public EN_98680591dcf3728e0877a90eb5e1e552EntityRecord ssENRequisition;

public EN_3554712eb61e9f0a2132c551df0f1db5EntityRecord ssENRequisitionAccounting;

public RL_7a479a555821b093171c5d3cd3382006 ssRLAllFiles;

public RL_7c236018492d50b3625a5b0d981eb4eb ssRLRequisitionAccConceptsRecordList;

public RL_943f36694cec370c0ce0c406bfa23715 ssRLRequisitionCostCenters;

public RL_b47d9310671b1b627f451a333bb8980a ssRLRequisitionServices;

public RC_cdb29de40f41bea5403aac7edb2d6159 ssRCi_RequisitionAccConcept_EstimEqualAg;


public BitArray OptimizedAttributes;

public RC_44742d4360afdf16ff97b37b2eff1760() {
OptimizedAttributes = null;
ssENRequisition = new EN_98680591dcf3728e0877a90eb5e1e552EntityRecord();
ssENRequisitionAccounting = new EN_3554712eb61e9f0a2132c551df0f1db5EntityRecord();
ssRLAllFiles = new RL_7a479a555821b093171c5d3cd3382006();
ssRLRequisitionAccConceptsRecordList = new RL_7c236018492d50b3625a5b0d981eb4eb();
ssRLRequisitionCostCenters = new RL_943f36694cec370c0ce0c406bfa23715();
ssRLRequisitionServices = new RL_b47d9310671b1b627f451a333bb8980a();
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
public void ReadIM(RC_44742d4360afdf16ff97b37b2eff1760 r) {
this = r;
}


public static bool operator == (RC_44742d4360afdf16ff97b37b2eff1760 a, RC_44742d4360afdf16ff97b37b2eff1760 b) {
if (a.ssENRequisition != b.ssENRequisition) return false;
if (a.ssENRequisitionAccounting != b.ssENRequisitionAccounting) return false;
if (a.ssRLAllFiles != b.ssRLAllFiles) return false;
if (a.ssRLRequisitionAccConceptsRecordList != b.ssRLRequisitionAccConceptsRecordList) return false;
if (a.ssRLRequisitionCostCenters != b.ssRLRequisitionCostCenters) return false;
if (a.ssRLRequisitionServices != b.ssRLRequisitionServices) return false;
if (a.ssRCi_RequisitionAccConcept_EstimEqualAg != b.ssRCi_RequisitionAccConcept_EstimEqualAg) return false;
return true;
}

public static bool operator != (RC_44742d4360afdf16ff97b37b2eff1760 a, RC_44742d4360afdf16ff97b37b2eff1760 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_44742d4360afdf16ff97b37b2eff1760)) return false;
return (this == (RC_44742d4360afdf16ff97b37b2eff1760)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENRequisition.GetHashCode()
 ^ ssENRequisitionAccounting.GetHashCode()
 ^ ssRLAllFiles.GetHashCode()
 ^ ssRLRequisitionAccConceptsRecordList.GetHashCode()
 ^ ssRLRequisitionCostCenters.GetHashCode()
 ^ ssRLRequisitionServices.GetHashCode()
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
ssRLRequisitionAccConceptsRecordList.RecursiveReset();
ssRLRequisitionCostCenters.RecursiveReset();
ssRLRequisitionServices.RecursiveReset();
ssRCi_RequisitionAccConcept_EstimEqualAg.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENRequisition.InternalRecursiveSave();
ssENRequisitionAccounting.InternalRecursiveSave();
ssRLAllFiles.InternalRecursiveSave();
ssRLRequisitionAccConceptsRecordList.InternalRecursiveSave();
ssRLRequisitionCostCenters.InternalRecursiveSave();
ssRLRequisitionServices.InternalRecursiveSave();
ssRCi_RequisitionAccConcept_EstimEqualAg.InternalRecursiveSave();
}


public RC_44742d4360afdf16ff97b37b2eff1760 Duplicate() {
RC_44742d4360afdf16ff97b37b2eff1760 t;
t.ssENRequisition = (EN_98680591dcf3728e0877a90eb5e1e552EntityRecord)this.ssENRequisition.Duplicate();
t.ssENRequisitionAccounting = (EN_3554712eb61e9f0a2132c551df0f1db5EntityRecord)this.ssENRequisitionAccounting.Duplicate();
t.ssRLAllFiles = (RL_7a479a555821b093171c5d3cd3382006)this.ssRLAllFiles.Duplicate();
t.ssRLRequisitionAccConceptsRecordList = (RL_7c236018492d50b3625a5b0d981eb4eb)this.ssRLRequisitionAccConceptsRecordList.Duplicate();
t.ssRLRequisitionCostCenters = (RL_943f36694cec370c0ce0c406bfa23715)this.ssRLRequisitionCostCenters.Duplicate();
t.ssRLRequisitionServices = (RL_b47d9310671b1b627f451a333bb8980a)this.ssRLRequisitionServices.Duplicate();
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
} else if (head == "requisitionaccconceptsrecordlist") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RequisitionAccConceptsRecordList")) variable.Value = ssRLRequisitionAccConceptsRecordList; else variable.Optimized = true;
variable.SetFieldName("requisitionaccconceptsrecordlist");
} else if (head == "requisitioncostcenters") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RequisitionCostCenters")) variable.Value = ssRLRequisitionCostCenters; else variable.Optimized = true;
variable.SetFieldName("requisitioncostcenters");
} else if (head == "requisitionservices") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RequisitionServices")) variable.Value = ssRLRequisitionServices; else variable.Optimized = true;
variable.SetFieldName("requisitionservices");
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
if (key == IdRequisitionAccConceptsRecordList) {
return ssRLRequisitionAccConceptsRecordList;
}
if (key == IdRequisitionCostCenters) {
return ssRLRequisitionCostCenters;
}
if (key == IdRequisitionServices) {
return ssRLRequisitionServices;
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
if (attributeKey == IdRequisitionAccConceptsRecordList.Key.AsGuid) {
return ssRLRequisitionAccConceptsRecordList;
}
if (attributeKey == IdRequisitionCostCenters.Key.AsGuid) {
return ssRLRequisitionCostCenters;
}
if (attributeKey == IdRequisitionServices.Key.AsGuid) {
return ssRLRequisitionServices;
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
ssRLRequisitionAccConceptsRecordList = new RL_7c236018492d50b3625a5b0d981eb4eb();
ssRLRequisitionAccConceptsRecordList.FillFromOther((IOSList) other.AttributeGet(IdRequisitionAccConceptsRecordList));
ssRLRequisitionCostCenters = new RL_943f36694cec370c0ce0c406bfa23715();
ssRLRequisitionCostCenters.FillFromOther((IOSList) other.AttributeGet(IdRequisitionCostCenters));
ssRLRequisitionServices = new RL_b47d9310671b1b627f451a333bb8980a();
ssRLRequisitionServices.FillFromOther((IOSList) other.AttributeGet(IdRequisitionServices));
ssRCi_RequisitionAccConcept_EstimEqualAg.FillFromOther((IRecord) other.AttributeGet(Idi_RequisitionAccConcept_EstimEqualAg));
}
} // RC_44742d4360afdf16ff97b37b2eff1760
/// <summary>
/// RecordList type
///  <code>RequisitionRequisitionAccountingAllFilesRequisitionAccConceptsRecordListRequisitionCostCenter
/// sRequisitionServicesi_RequisitionAccConcept_EstimEqualAgRecordList</code> that represents a record
///  list of <code>Requisition, RequisitionAccounting, RequisitionFileTypesStructList
/// , RequisitionAccConceptsAccountingDataTypeRecordList, RequisitionCostCenterList,
///  RequisitionServiceRecordList, MainAccConceptSubAccConceptsRecord</code>
/// </summary>
public partial class RL_2f1838fbbdcad31102ce7e104f3ee1a3 : GenericRecordList<RC_44742d4360afdf16ff97b37b2eff1760>, IEnumerable, IEnumerator {

protected override RC_44742d4360afdf16ff97b37b2eff1760 GetElementDefaultValue() {
return new RC_44742d4360afdf16ff97b37b2eff1760();
}

public T[] ToArray<T>(Func<RC_44742d4360afdf16ff97b37b2eff1760, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_2f1838fbbdcad31102ce7e104f3ee1a3 recordList, Func<RC_44742d4360afdf16ff97b37b2eff1760, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_2f1838fbbdcad31102ce7e104f3ee1a3(RC_44742d4360afdf16ff97b37b2eff1760[] array) {
  RL_2f1838fbbdcad31102ce7e104f3ee1a3 result = new RL_2f1838fbbdcad31102ce7e104f3ee1a3();
result.InnerFromArray(array);
    return result;
}

public static RL_2f1838fbbdcad31102ce7e104f3ee1a3 ToList<T>(T[] array, Func <T, RC_44742d4360afdf16ff97b37b2eff1760> converter) {
  RL_2f1838fbbdcad31102ce7e104f3ee1a3 result = new RL_2f1838fbbdcad31102ce7e104f3ee1a3();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_2f1838fbbdcad31102ce7e104f3ee1a3 FromRestList<T>(RestList<T> restList, Func <T, RC_44742d4360afdf16ff97b37b2eff1760> converter) {
  RL_2f1838fbbdcad31102ce7e104f3ee1a3 result = new RL_2f1838fbbdcad31102ce7e104f3ee1a3();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_2f1838fbbdcad31102ce7e104f3ee1a3() : base() {
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
protected override OSList<RC_44742d4360afdf16ff97b37b2eff1760> NewList() {
return new RL_2f1838fbbdcad31102ce7e104f3ee1a3();
}


} // RL_2f1838fbbdcad31102ce7e104f3ee1a3
}

