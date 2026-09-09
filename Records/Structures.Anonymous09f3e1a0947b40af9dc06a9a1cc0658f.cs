namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (oOHzCXuUr0CdwGqaHMBljw)
///  <code>RC_7fadf2cbff2fecd5fbe9b2e13c5588e9</code> that represent
/// s <code>RequisitionRequisitionStatusDistributionFrequencyRecord</code> <p>Description: </p>
/// </summary>
// Name: RequisitionRequisitionStatusDistributionFrequencyRecord
public partial struct RC_7fadf2cbff2fecd5fbe9b2e13c5588e9 : ITypedRecord<RC_7fadf2cbff2fecd5fbe9b2e13c5588e9> {
internal static readonly GlobalObjectKey IdRequisition = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*T3SBu1iqc67nzY23TLMhVQ");
internal static readonly GlobalObjectKey IdRequisitionStatus = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*2VyosKSDP_TsIKnpR3QQSw");
internal static readonly GlobalObjectKey IdDistribution = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*CCJIpkzC5uLJxroW5XsBhQ");
internal static readonly GlobalObjectKey IdFrequency = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*2AnG8vhYHkF1++3uYMXd3w");

public EN_98680591dcf3728e0877a90eb5e1e552EntityRecord ssENRequisition;

public EN_0554a1252840ba4a5c4e6af5899608adEntityRecord ssENRequisitionStatus;

public EN_88460e7eac2a65d244abb23fe44af0adEntityRecord ssENDistribution;

public EN_a6239c65aa61ed4530d18a92034301bbEntityRecord ssENFrequency;


public BitArray OptimizedAttributes;

public RC_7fadf2cbff2fecd5fbe9b2e13c5588e9() {
OptimizedAttributes = null;
ssENRequisition = new EN_98680591dcf3728e0877a90eb5e1e552EntityRecord();
ssENRequisitionStatus = new EN_0554a1252840ba4a5c4e6af5899608adEntityRecord();
ssENDistribution = new EN_88460e7eac2a65d244abb23fe44af0adEntityRecord();
ssENFrequency = new EN_a6239c65aa61ed4530d18a92034301bbEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[4];
    all[0] = new BitArray(58,false);
    all[1] = new BitArray(6,false);
    all[2] = new BitArray(4,false);
    all[3] = new BitArray(4,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENRequisition.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENRequisitionStatus.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENDistribution.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    ssENFrequency.OptimizedAttributes = GetDefaultOptimizedValues()[3];
    }else{
    ssENRequisition.OptimizedAttributes = value[0];
    ssENRequisitionStatus.OptimizedAttributes = value[1];
    ssENDistribution.OptimizedAttributes = value[2];
    ssENFrequency.OptimizedAttributes = value[3];
    }
}
get{
    BitArray[] all = new BitArray[4];
    all[0] = ssENRequisition.OptimizedAttributes;
    all[1] = ssENRequisitionStatus.OptimizedAttributes;
    all[2] = ssENDistribution.OptimizedAttributes;
    all[3] = ssENFrequency.OptimizedAttributes;
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
ssENRequisitionStatus.Read( r, ref index);
ssENDistribution.Read( r, ref index);
ssENFrequency.Read( r, ref index);
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
public void ReadIM(RC_7fadf2cbff2fecd5fbe9b2e13c5588e9 r) {
this = r;
}


public static bool operator == (RC_7fadf2cbff2fecd5fbe9b2e13c5588e9 a, RC_7fadf2cbff2fecd5fbe9b2e13c5588e9 b) {
if (a.ssENRequisition != b.ssENRequisition) return false;
if (a.ssENRequisitionStatus != b.ssENRequisitionStatus) return false;
if (a.ssENDistribution != b.ssENDistribution) return false;
if (a.ssENFrequency != b.ssENFrequency) return false;
return true;
}

public static bool operator != (RC_7fadf2cbff2fecd5fbe9b2e13c5588e9 a, RC_7fadf2cbff2fecd5fbe9b2e13c5588e9 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_7fadf2cbff2fecd5fbe9b2e13c5588e9)) return false;
return (this == (RC_7fadf2cbff2fecd5fbe9b2e13c5588e9)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENRequisition.GetHashCode()
 ^ ssENRequisitionStatus.GetHashCode()
 ^ ssENDistribution.GetHashCode()
 ^ ssENFrequency.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENRequisition.RecursiveReset();
ssENRequisitionStatus.RecursiveReset();
ssENDistribution.RecursiveReset();
ssENFrequency.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENRequisition.InternalRecursiveSave();
ssENRequisitionStatus.InternalRecursiveSave();
ssENDistribution.InternalRecursiveSave();
ssENFrequency.InternalRecursiveSave();
}


public RC_7fadf2cbff2fecd5fbe9b2e13c5588e9 Duplicate() {
RC_7fadf2cbff2fecd5fbe9b2e13c5588e9 t;
t.ssENRequisition = (EN_98680591dcf3728e0877a90eb5e1e552EntityRecord)this.ssENRequisition.Duplicate();
t.ssENRequisitionStatus = (EN_0554a1252840ba4a5c4e6af5899608adEntityRecord)this.ssENRequisitionStatus.Duplicate();
t.ssENDistribution = (EN_88460e7eac2a65d244abb23fe44af0adEntityRecord)this.ssENDistribution.Duplicate();
t.ssENFrequency = (EN_a6239c65aa61ed4530d18a92034301bbEntityRecord)this.ssENFrequency.Duplicate();
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
} else if (head == "requisitionstatus") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RequisitionStatus")) variable.Value = ssENRequisitionStatus; else variable.Optimized = true;
variable.SetFieldName("requisitionstatus");
} else if (head == "distribution") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Distribution")) variable.Value = ssENDistribution; else variable.Optimized = true;
variable.SetFieldName("distribution");
} else if (head == "frequency") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Frequency")) variable.Value = ssENFrequency; else variable.Optimized = true;
variable.SetFieldName("frequency");
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
if (key == IdRequisitionStatus) {
return ssENRequisitionStatus;
}
if (key == IdDistribution) {
return ssENDistribution;
}
if (key == IdFrequency) {
return ssENFrequency;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdRequisition.Key.AsGuid) {
return ssENRequisition;
}
if (attributeKey == IdRequisitionStatus.Key.AsGuid) {
return ssENRequisitionStatus;
}
if (attributeKey == IdDistribution.Key.AsGuid) {
return ssENDistribution;
}
if (attributeKey == IdFrequency.Key.AsGuid) {
return ssENFrequency;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENRequisition.FillFromOther((IRecord) other.AttributeGet(IdRequisition));
ssENRequisitionStatus.FillFromOther((IRecord) other.AttributeGet(IdRequisitionStatus));
ssENDistribution.FillFromOther((IRecord) other.AttributeGet(IdDistribution));
ssENFrequency.FillFromOther((IRecord) other.AttributeGet(IdFrequency));
}
} // RC_7fadf2cbff2fecd5fbe9b2e13c5588e9
/// <summary>
/// RecordList type <code>RequisitionRequisitionStatusDistributionFrequencyRecordList</code> that
///  represents a record list of <code>Requisition, RequisitionStatus, Distribution, Frequency</code>
/// </summary>
public partial class RL_c30d58936515a1bd8b3b632af88fba4d : GenericRecordList<RC_7fadf2cbff2fecd5fbe9b2e13c5588e9>, IEnumerable, IEnumerator {

protected override RC_7fadf2cbff2fecd5fbe9b2e13c5588e9 GetElementDefaultValue() {
return new RC_7fadf2cbff2fecd5fbe9b2e13c5588e9();
}

public T[] ToArray<T>(Func<RC_7fadf2cbff2fecd5fbe9b2e13c5588e9, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_c30d58936515a1bd8b3b632af88fba4d recordList, Func<RC_7fadf2cbff2fecd5fbe9b2e13c5588e9, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_c30d58936515a1bd8b3b632af88fba4d(RC_7fadf2cbff2fecd5fbe9b2e13c5588e9[] array) {
  RL_c30d58936515a1bd8b3b632af88fba4d result = new RL_c30d58936515a1bd8b3b632af88fba4d();
result.InnerFromArray(array);
    return result;
}

public static RL_c30d58936515a1bd8b3b632af88fba4d ToList<T>(T[] array, Func <T, RC_7fadf2cbff2fecd5fbe9b2e13c5588e9> converter) {
  RL_c30d58936515a1bd8b3b632af88fba4d result = new RL_c30d58936515a1bd8b3b632af88fba4d();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_c30d58936515a1bd8b3b632af88fba4d FromRestList<T>(RestList<T> restList, Func <T, RC_7fadf2cbff2fecd5fbe9b2e13c5588e9> converter) {
  RL_c30d58936515a1bd8b3b632af88fba4d result = new RL_c30d58936515a1bd8b3b632af88fba4d();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_c30d58936515a1bd8b3b632af88fba4d() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[4];
def[0] = new BitArray(58,false);
def[1] = new BitArray(6,false);
def[2] = new BitArray(4,false);
def[3] = new BitArray(4,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_7fadf2cbff2fecd5fbe9b2e13c5588e9> NewList() {
return new RL_c30d58936515a1bd8b3b632af88fba4d();
}


} // RL_c30d58936515a1bd8b3b632af88fba4d
}

