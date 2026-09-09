namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (cQ8oSy0XTUeUBn8iUXt1CQ)
///  <code>RC_d66b0b09097e5f0bc1ec31076e9aa762</code> that represent
/// s <code>RequisitionAllFilesRecord</code> <p>Description: </p>
/// </summary>
// Name: RequisitionAllFilesRecord
public partial struct RC_d66b0b09097e5f0bc1ec31076e9aa762 : ITypedRecord<RC_d66b0b09097e5f0bc1ec31076e9aa762> {
internal static readonly GlobalObjectKey IdRequisition = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*T3SBu1iqc67nzY23TLMhVQ");
internal static readonly GlobalObjectKey IdAllFiles = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*KqdTsstzCB2_m5J6zxgrQw");

public EN_98680591dcf3728e0877a90eb5e1e552EntityRecord ssENRequisition;

public RL_7a479a555821b093171c5d3cd3382006 ssRLAllFiles;


public BitArray OptimizedAttributes;

public RC_d66b0b09097e5f0bc1ec31076e9aa762() {
OptimizedAttributes = null;
ssENRequisition = new EN_98680591dcf3728e0877a90eb5e1e552EntityRecord();
ssRLAllFiles = new RL_7a479a555821b093171c5d3cd3382006();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(58,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENRequisition.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENRequisition.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENRequisition.OptimizedAttributes;
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
public void ReadIM(RC_d66b0b09097e5f0bc1ec31076e9aa762 r) {
this = r;
}


public static bool operator == (RC_d66b0b09097e5f0bc1ec31076e9aa762 a, RC_d66b0b09097e5f0bc1ec31076e9aa762 b) {
if (a.ssENRequisition != b.ssENRequisition) return false;
if (a.ssRLAllFiles != b.ssRLAllFiles) return false;
return true;
}

public static bool operator != (RC_d66b0b09097e5f0bc1ec31076e9aa762 a, RC_d66b0b09097e5f0bc1ec31076e9aa762 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_d66b0b09097e5f0bc1ec31076e9aa762)) return false;
return (this == (RC_d66b0b09097e5f0bc1ec31076e9aa762)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENRequisition.GetHashCode()
 ^ ssRLAllFiles.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENRequisition.RecursiveReset();
ssRLAllFiles.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENRequisition.InternalRecursiveSave();
ssRLAllFiles.InternalRecursiveSave();
}


public RC_d66b0b09097e5f0bc1ec31076e9aa762 Duplicate() {
RC_d66b0b09097e5f0bc1ec31076e9aa762 t;
t.ssENRequisition = (EN_98680591dcf3728e0877a90eb5e1e552EntityRecord)this.ssENRequisition.Duplicate();
t.ssRLAllFiles = (RL_7a479a555821b093171c5d3cd3382006)this.ssRLAllFiles.Duplicate();
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
} else if (head == "allfiles") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".AllFiles")) variable.Value = ssRLAllFiles; else variable.Optimized = true;
variable.SetFieldName("allfiles");
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
if (key == IdAllFiles) {
return ssRLAllFiles;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdRequisition.Key.AsGuid) {
return ssENRequisition;
}
if (attributeKey == IdAllFiles.Key.AsGuid) {
return ssRLAllFiles;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENRequisition.FillFromOther((IRecord) other.AttributeGet(IdRequisition));
ssRLAllFiles = new RL_7a479a555821b093171c5d3cd3382006();
ssRLAllFiles.FillFromOther((IOSList) other.AttributeGet(IdAllFiles));
}
} // RC_d66b0b09097e5f0bc1ec31076e9aa762
/// <summary>
/// RecordList type <code>RequisitionAllFilesRecordList</code> that represents a record list of
///  <code>Requisition, RequisitionFileTypesStructList</code>
/// </summary>
public partial class RL_9836e7e4b8d6ce906f31e9f5dd48996f : GenericRecordList<RC_d66b0b09097e5f0bc1ec31076e9aa762>, IEnumerable, IEnumerator {

protected override RC_d66b0b09097e5f0bc1ec31076e9aa762 GetElementDefaultValue() {
return new RC_d66b0b09097e5f0bc1ec31076e9aa762();
}

public T[] ToArray<T>(Func<RC_d66b0b09097e5f0bc1ec31076e9aa762, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_9836e7e4b8d6ce906f31e9f5dd48996f recordList, Func<RC_d66b0b09097e5f0bc1ec31076e9aa762, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_9836e7e4b8d6ce906f31e9f5dd48996f(RC_d66b0b09097e5f0bc1ec31076e9aa762[] array) {
  RL_9836e7e4b8d6ce906f31e9f5dd48996f result = new RL_9836e7e4b8d6ce906f31e9f5dd48996f();
result.InnerFromArray(array);
    return result;
}

public static RL_9836e7e4b8d6ce906f31e9f5dd48996f ToList<T>(T[] array, Func <T, RC_d66b0b09097e5f0bc1ec31076e9aa762> converter) {
  RL_9836e7e4b8d6ce906f31e9f5dd48996f result = new RL_9836e7e4b8d6ce906f31e9f5dd48996f();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_9836e7e4b8d6ce906f31e9f5dd48996f FromRestList<T>(RestList<T> restList, Func <T, RC_d66b0b09097e5f0bc1ec31076e9aa762> converter) {
  RL_9836e7e4b8d6ce906f31e9f5dd48996f result = new RL_9836e7e4b8d6ce906f31e9f5dd48996f();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_9836e7e4b8d6ce906f31e9f5dd48996f() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(58,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_d66b0b09097e5f0bc1ec31076e9aa762> NewList() {
return new RL_9836e7e4b8d6ce906f31e9f5dd48996f();
}


} // RL_9836e7e4b8d6ce906f31e9f5dd48996f
}

