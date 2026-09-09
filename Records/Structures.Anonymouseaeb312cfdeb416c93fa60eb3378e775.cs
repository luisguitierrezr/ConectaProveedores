namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (LDHr6uv9bEGT+mDrM3jndQ)
///  <code>RC_8171c5e0188443e9384b8f5492517b0e</code> that represent
/// s <code>OrderContractFileOrderFileRecord</code> <p>Description: </p>
/// </summary>
// Name: OrderContractFileOrderFileRecord
public partial struct RC_8171c5e0188443e9384b8f5492517b0e : ITypedRecord<RC_8171c5e0188443e9384b8f5492517b0e> {
internal static readonly GlobalObjectKey IdOrderContractFile = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*Ls24vaMN4urxcJQolfKjrA");
internal static readonly GlobalObjectKey IdOrderFile = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*NUo5p8E99rc2qs7SCeZhFg");

public EN_17538b35348920159ed0ee43b3fb2b50EntityRecord ssENOrderContractFile;

public EN_096339be3ef098b3762e8897e3a1c095EntityRecord ssENOrderFile;


public BitArray OptimizedAttributes;

public RC_8171c5e0188443e9384b8f5492517b0e() {
OptimizedAttributes = null;
ssENOrderContractFile = new EN_17538b35348920159ed0ee43b3fb2b50EntityRecord();
ssENOrderFile = new EN_096339be3ef098b3762e8897e3a1c095EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[2];
    all[0] = new BitArray(14,false);
    all[1] = new BitArray(8,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENOrderContractFile.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENOrderFile.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    }else{
    ssENOrderContractFile.OptimizedAttributes = value[0];
    ssENOrderFile.OptimizedAttributes = value[1];
    }
}
get{
    BitArray[] all = new BitArray[2];
    all[0] = ssENOrderContractFile.OptimizedAttributes;
    all[1] = ssENOrderFile.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENOrderContractFile.Read( r, ref index);
ssENOrderFile.Read( r, ref index);
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
public void ReadIM(RC_8171c5e0188443e9384b8f5492517b0e r) {
this = r;
}


public static bool operator == (RC_8171c5e0188443e9384b8f5492517b0e a, RC_8171c5e0188443e9384b8f5492517b0e b) {
if (a.ssENOrderContractFile != b.ssENOrderContractFile) return false;
if (a.ssENOrderFile != b.ssENOrderFile) return false;
return true;
}

public static bool operator != (RC_8171c5e0188443e9384b8f5492517b0e a, RC_8171c5e0188443e9384b8f5492517b0e b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_8171c5e0188443e9384b8f5492517b0e)) return false;
return (this == (RC_8171c5e0188443e9384b8f5492517b0e)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENOrderContractFile.GetHashCode()
 ^ ssENOrderFile.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENOrderContractFile.RecursiveReset();
ssENOrderFile.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENOrderContractFile.InternalRecursiveSave();
ssENOrderFile.InternalRecursiveSave();
}


public RC_8171c5e0188443e9384b8f5492517b0e Duplicate() {
RC_8171c5e0188443e9384b8f5492517b0e t;
t.ssENOrderContractFile = (EN_17538b35348920159ed0ee43b3fb2b50EntityRecord)this.ssENOrderContractFile.Duplicate();
t.ssENOrderFile = (EN_096339be3ef098b3762e8897e3a1c095EntityRecord)this.ssENOrderFile.Duplicate();
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
if (head == "ordercontractfile") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderContractFile")) variable.Value = ssENOrderContractFile; else variable.Optimized = true;
variable.SetFieldName("ordercontractfile");
} else if (head == "orderfile") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderFile")) variable.Value = ssENOrderFile; else variable.Optimized = true;
variable.SetFieldName("orderfile");
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
if (key == IdOrderContractFile) {
return ssENOrderContractFile;
}
if (key == IdOrderFile) {
return ssENOrderFile;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdOrderContractFile.Key.AsGuid) {
return ssENOrderContractFile;
}
if (attributeKey == IdOrderFile.Key.AsGuid) {
return ssENOrderFile;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENOrderContractFile.FillFromOther((IRecord) other.AttributeGet(IdOrderContractFile));
ssENOrderFile.FillFromOther((IRecord) other.AttributeGet(IdOrderFile));
}
} // RC_8171c5e0188443e9384b8f5492517b0e
/// <summary>
/// RecordList type <code>OrderContractFileOrderFileRecordList</code> that represents a record list of
///  <code>OrderContractFile, OrderFile</code>
/// </summary>
public partial class RL_16bc0f170c91ed9fd3ef42e01c4db2cf : GenericRecordList<RC_8171c5e0188443e9384b8f5492517b0e>, IEnumerable, IEnumerator {

protected override RC_8171c5e0188443e9384b8f5492517b0e GetElementDefaultValue() {
return new RC_8171c5e0188443e9384b8f5492517b0e();
}

public T[] ToArray<T>(Func<RC_8171c5e0188443e9384b8f5492517b0e, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_16bc0f170c91ed9fd3ef42e01c4db2cf recordList, Func<RC_8171c5e0188443e9384b8f5492517b0e, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_16bc0f170c91ed9fd3ef42e01c4db2cf(RC_8171c5e0188443e9384b8f5492517b0e[] array) {
  RL_16bc0f170c91ed9fd3ef42e01c4db2cf result = new RL_16bc0f170c91ed9fd3ef42e01c4db2cf();
result.InnerFromArray(array);
    return result;
}

public static RL_16bc0f170c91ed9fd3ef42e01c4db2cf ToList<T>(T[] array, Func <T, RC_8171c5e0188443e9384b8f5492517b0e> converter) {
  RL_16bc0f170c91ed9fd3ef42e01c4db2cf result = new RL_16bc0f170c91ed9fd3ef42e01c4db2cf();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_16bc0f170c91ed9fd3ef42e01c4db2cf FromRestList<T>(RestList<T> restList, Func <T, RC_8171c5e0188443e9384b8f5492517b0e> converter) {
  RL_16bc0f170c91ed9fd3ef42e01c4db2cf result = new RL_16bc0f170c91ed9fd3ef42e01c4db2cf();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_16bc0f170c91ed9fd3ef42e01c4db2cf() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[2];
def[0] = new BitArray(14,false);
def[1] = new BitArray(8,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_8171c5e0188443e9384b8f5492517b0e> NewList() {
return new RL_16bc0f170c91ed9fd3ef42e01c4db2cf();
}


} // RL_16bc0f170c91ed9fd3ef42e01c4db2cf
}

