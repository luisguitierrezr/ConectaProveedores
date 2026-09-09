namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (NSc8OhjhwkKnk6fzIvCptQ)
///  <code>RC_eed89a9c1fe70a448325856911f34fe5</code> that represents <code>MFU_FileRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: MFU_FileRecord
public partial struct RC_eed89a9c1fe70a448325856911f34fe5 : ITypedRecord<RC_eed89a9c1fe70a448325856911f34fe5> {
internal static readonly GlobalObjectKey IdMFU_File = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*nJrY7ucfRAqDJYVpEfNP5Q");

public ST_1d6498da9105fbe815a7f766352917c0Structure ssSTMFU_File;


public static implicit operator ST_1d6498da9105fbe815a7f766352917c0Structure( RC_eed89a9c1fe70a448325856911f34fe5 r) {
return r.ssSTMFU_File;
}

public static implicit operator RC_eed89a9c1fe70a448325856911f34fe5 (ST_1d6498da9105fbe815a7f766352917c0Structure r) {
RC_eed89a9c1fe70a448325856911f34fe5 res = new RC_eed89a9c1fe70a448325856911f34fe5 ();
res.ssSTMFU_File = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_eed89a9c1fe70a448325856911f34fe5() {
OptimizedAttributes = null;
ssSTMFU_File = new ST_1d6498da9105fbe815a7f766352917c0Structure();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = null;
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    }else{
    ssSTMFU_File.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = null;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssSTMFU_File.Read( r, ref index);
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
public void ReadIM(RC_eed89a9c1fe70a448325856911f34fe5 r) {
this = r;
}


public static bool operator == (RC_eed89a9c1fe70a448325856911f34fe5 a, RC_eed89a9c1fe70a448325856911f34fe5 b) {
if (a.ssSTMFU_File != b.ssSTMFU_File) return false;
return true;
}

public static bool operator != (RC_eed89a9c1fe70a448325856911f34fe5 a, RC_eed89a9c1fe70a448325856911f34fe5 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_eed89a9c1fe70a448325856911f34fe5)) return false;
return (this == (RC_eed89a9c1fe70a448325856911f34fe5)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTMFU_File.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTMFU_File.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTMFU_File.InternalRecursiveSave();
}


public RC_eed89a9c1fe70a448325856911f34fe5 Duplicate() {
RC_eed89a9c1fe70a448325856911f34fe5 t;
t.ssSTMFU_File = (ST_1d6498da9105fbe815a7f766352917c0Structure)this.ssSTMFU_File.Duplicate();
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
if (head == "mfu_file") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".MFU_File")) variable.Value = ssSTMFU_File; else variable.Optimized = true;
variable.SetFieldName("mfu_file");
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
if (key == IdMFU_File) {
return ssSTMFU_File;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdMFU_File.Key.AsGuid) {
return ssSTMFU_File;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTMFU_File.FillFromOther((IRecord) other.AttributeGet(IdMFU_File));
}
} // RC_eed89a9c1fe70a448325856911f34fe5
/// <summary>
/// RecordList type <code>MFU_FileRecordList</code> that represents a record list of
///  <code>MFU_File</code>
/// </summary>
public partial class RL_f02ff640632cf34294664d10f313a512 : GenericRecordList<RC_eed89a9c1fe70a448325856911f34fe5>, IEnumerable, IEnumerator {

protected override RC_eed89a9c1fe70a448325856911f34fe5 GetElementDefaultValue() {
return new RC_eed89a9c1fe70a448325856911f34fe5();
}

public T[] ToArray<T>(Func<RC_eed89a9c1fe70a448325856911f34fe5, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_f02ff640632cf34294664d10f313a512 recordList, Func<RC_eed89a9c1fe70a448325856911f34fe5, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_f02ff640632cf34294664d10f313a512(RC_eed89a9c1fe70a448325856911f34fe5[] array) {
  RL_f02ff640632cf34294664d10f313a512 result = new RL_f02ff640632cf34294664d10f313a512();
result.InnerFromArray(array);
    return result;
}

public static RL_f02ff640632cf34294664d10f313a512 ToList<T>(T[] array, Func <T, RC_eed89a9c1fe70a448325856911f34fe5> converter) {
  RL_f02ff640632cf34294664d10f313a512 result = new RL_f02ff640632cf34294664d10f313a512();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_f02ff640632cf34294664d10f313a512 FromRestList<T>(RestList<T> restList, Func <T, RC_eed89a9c1fe70a448325856911f34fe5> converter) {
  RL_f02ff640632cf34294664d10f313a512 result = new RL_f02ff640632cf34294664d10f313a512();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_f02ff640632cf34294664d10f313a512() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = null;
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_eed89a9c1fe70a448325856911f34fe5> NewList() {
return new RL_f02ff640632cf34294664d10f313a512();
}


} // RL_f02ff640632cf34294664d10f313a512
}

