namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (1vVjd5mLLk+Ve0jkOlMlsw)
///  <code>RC_c3feeb794fa34d46adcdce2db9588d18</code> that represent
/// s <code>RequisitionContractFileRequisitionRequisitionFile2Record</code> <p>Description: </p>
/// </summary>
// Name: RequisitionContractFileRequisitionRequisitionFile2Record
public partial struct RC_c3feeb794fa34d46adcdce2db9588d18 : ITypedRecord<RC_c3feeb794fa34d46adcdce2db9588d18> {
internal static readonly GlobalObjectKey IdRequisitionContractFile = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*QcYeR2FJwD6p81JfwtnhHA");
internal static readonly GlobalObjectKey IdRequisition = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*T3SBu1iqc67nzY23TLMhVQ");
internal static readonly GlobalObjectKey IdRequisitionFile2 = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*NbYPPv7ugJRU+nVCFUapAQ");

public EN_aeab0089a9236dfc6c684ea98f650647EntityRecord ssENRequisitionContractFile;

public EN_98680591dcf3728e0877a90eb5e1e552EntityRecord ssENRequisition;

public EN_4cce425e15647f937e21de4e52849889EntityRecord ssENRequisitionFile2;


public BitArray OptimizedAttributes;

public RC_c3feeb794fa34d46adcdce2db9588d18() {
OptimizedAttributes = null;
ssENRequisitionContractFile = new EN_aeab0089a9236dfc6c684ea98f650647EntityRecord();
ssENRequisition = new EN_98680591dcf3728e0877a90eb5e1e552EntityRecord();
ssENRequisitionFile2 = new EN_4cce425e15647f937e21de4e52849889EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[3];
    all[0] = new BitArray(9,false);
    all[1] = new BitArray(58,false);
    all[2] = new BitArray(8,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENRequisitionContractFile.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENRequisition.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENRequisitionFile2.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    }else{
    ssENRequisitionContractFile.OptimizedAttributes = value[0];
    ssENRequisition.OptimizedAttributes = value[1];
    ssENRequisitionFile2.OptimizedAttributes = value[2];
    }
}
get{
    BitArray[] all = new BitArray[3];
    all[0] = ssENRequisitionContractFile.OptimizedAttributes;
    all[1] = ssENRequisition.OptimizedAttributes;
    all[2] = ssENRequisitionFile2.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENRequisitionContractFile.Read( r, ref index);
ssENRequisition.Read( r, ref index);
ssENRequisitionFile2.Read( r, ref index);
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
public void ReadIM(RC_c3feeb794fa34d46adcdce2db9588d18 r) {
this = r;
}


public static bool operator == (RC_c3feeb794fa34d46adcdce2db9588d18 a, RC_c3feeb794fa34d46adcdce2db9588d18 b) {
if (a.ssENRequisitionContractFile != b.ssENRequisitionContractFile) return false;
if (a.ssENRequisition != b.ssENRequisition) return false;
if (a.ssENRequisitionFile2 != b.ssENRequisitionFile2) return false;
return true;
}

public static bool operator != (RC_c3feeb794fa34d46adcdce2db9588d18 a, RC_c3feeb794fa34d46adcdce2db9588d18 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_c3feeb794fa34d46adcdce2db9588d18)) return false;
return (this == (RC_c3feeb794fa34d46adcdce2db9588d18)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENRequisitionContractFile.GetHashCode()
 ^ ssENRequisition.GetHashCode()
 ^ ssENRequisitionFile2.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENRequisitionContractFile.RecursiveReset();
ssENRequisition.RecursiveReset();
ssENRequisitionFile2.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENRequisitionContractFile.InternalRecursiveSave();
ssENRequisition.InternalRecursiveSave();
ssENRequisitionFile2.InternalRecursiveSave();
}


public RC_c3feeb794fa34d46adcdce2db9588d18 Duplicate() {
RC_c3feeb794fa34d46adcdce2db9588d18 t;
t.ssENRequisitionContractFile = (EN_aeab0089a9236dfc6c684ea98f650647EntityRecord)this.ssENRequisitionContractFile.Duplicate();
t.ssENRequisition = (EN_98680591dcf3728e0877a90eb5e1e552EntityRecord)this.ssENRequisition.Duplicate();
t.ssENRequisitionFile2 = (EN_4cce425e15647f937e21de4e52849889EntityRecord)this.ssENRequisitionFile2.Duplicate();
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
if (head == "requisitioncontractfile") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RequisitionContractFile")) variable.Value = ssENRequisitionContractFile; else variable.Optimized = true;
variable.SetFieldName("requisitioncontractfile");
} else if (head == "requisition") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Requisition")) variable.Value = ssENRequisition; else variable.Optimized = true;
variable.SetFieldName("requisition");
} else if (head == "requisitionfile2") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RequisitionFile2")) variable.Value = ssENRequisitionFile2; else variable.Optimized = true;
variable.SetFieldName("requisitionfile2");
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
if (key == IdRequisitionContractFile) {
return ssENRequisitionContractFile;
}
if (key == IdRequisition) {
return ssENRequisition;
}
if (key == IdRequisitionFile2) {
return ssENRequisitionFile2;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdRequisitionContractFile.Key.AsGuid) {
return ssENRequisitionContractFile;
}
if (attributeKey == IdRequisition.Key.AsGuid) {
return ssENRequisition;
}
if (attributeKey == IdRequisitionFile2.Key.AsGuid) {
return ssENRequisitionFile2;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENRequisitionContractFile.FillFromOther((IRecord) other.AttributeGet(IdRequisitionContractFile));
ssENRequisition.FillFromOther((IRecord) other.AttributeGet(IdRequisition));
ssENRequisitionFile2.FillFromOther((IRecord) other.AttributeGet(IdRequisitionFile2));
}
} // RC_c3feeb794fa34d46adcdce2db9588d18
/// <summary>
/// RecordList type <code>RequisitionContractFileRequisitionRequisitionFile2RecordList</code> that
///  represents a record list of <code>RequisitionContractFile, Requisition, RequisitionFile2</code>
/// </summary>
public partial class RL_8794daf8a03a814b6ca9e26cee0933c6 : GenericRecordList<RC_c3feeb794fa34d46adcdce2db9588d18>, IEnumerable, IEnumerator {

protected override RC_c3feeb794fa34d46adcdce2db9588d18 GetElementDefaultValue() {
return new RC_c3feeb794fa34d46adcdce2db9588d18();
}

public T[] ToArray<T>(Func<RC_c3feeb794fa34d46adcdce2db9588d18, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_8794daf8a03a814b6ca9e26cee0933c6 recordList, Func<RC_c3feeb794fa34d46adcdce2db9588d18, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_8794daf8a03a814b6ca9e26cee0933c6(RC_c3feeb794fa34d46adcdce2db9588d18[] array) {
  RL_8794daf8a03a814b6ca9e26cee0933c6 result = new RL_8794daf8a03a814b6ca9e26cee0933c6();
result.InnerFromArray(array);
    return result;
}

public static RL_8794daf8a03a814b6ca9e26cee0933c6 ToList<T>(T[] array, Func <T, RC_c3feeb794fa34d46adcdce2db9588d18> converter) {
  RL_8794daf8a03a814b6ca9e26cee0933c6 result = new RL_8794daf8a03a814b6ca9e26cee0933c6();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_8794daf8a03a814b6ca9e26cee0933c6 FromRestList<T>(RestList<T> restList, Func <T, RC_c3feeb794fa34d46adcdce2db9588d18> converter) {
  RL_8794daf8a03a814b6ca9e26cee0933c6 result = new RL_8794daf8a03a814b6ca9e26cee0933c6();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_8794daf8a03a814b6ca9e26cee0933c6() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[3];
def[0] = new BitArray(9,false);
def[1] = new BitArray(58,false);
def[2] = new BitArray(8,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_c3feeb794fa34d46adcdce2db9588d18> NewList() {
return new RL_8794daf8a03a814b6ca9e26cee0933c6();
}


} // RL_8794daf8a03a814b6ca9e26cee0933c6
}

