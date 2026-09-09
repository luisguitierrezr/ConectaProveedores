namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (mntbRomYdEKJuOj8qFjCyQ)
///  <code>RC_d200060d081b41826672020864051a96</code> that represents <code>BooleanRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: BooleanRecord
public partial struct RC_d200060d081b41826672020864051a96 : ITypedRecord<RC_d200060d081b41826672020864051a96> {
internal static readonly GlobalObjectKey IdBoolean = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*DQYA0hsIgkFmcgIIZAUalg");

public ST_b6d345dd13582e4e92d7108f300179feStructure ssSTBoolean;


public static implicit operator ST_b6d345dd13582e4e92d7108f300179feStructure( RC_d200060d081b41826672020864051a96 r) {
return r.ssSTBoolean;
}

public static implicit operator RC_d200060d081b41826672020864051a96 (ST_b6d345dd13582e4e92d7108f300179feStructure r) {
RC_d200060d081b41826672020864051a96 res = new RC_d200060d081b41826672020864051a96 ();
res.ssSTBoolean = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_d200060d081b41826672020864051a96() {
OptimizedAttributes = null;
ssSTBoolean = new ST_b6d345dd13582e4e92d7108f300179feStructure();
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
    ssSTBoolean.OptimizedAttributes = value[0];
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
ssSTBoolean.Read( r, ref index);
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
public void ReadIM(RC_d200060d081b41826672020864051a96 r) {
this = r;
}


public static bool operator == (RC_d200060d081b41826672020864051a96 a, RC_d200060d081b41826672020864051a96 b) {
if (a.ssSTBoolean != b.ssSTBoolean) return false;
return true;
}

public static bool operator != (RC_d200060d081b41826672020864051a96 a, RC_d200060d081b41826672020864051a96 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_d200060d081b41826672020864051a96)) return false;
return (this == (RC_d200060d081b41826672020864051a96)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTBoolean.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTBoolean.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTBoolean.InternalRecursiveSave();
}


public RC_d200060d081b41826672020864051a96 Duplicate() {
RC_d200060d081b41826672020864051a96 t;
t.ssSTBoolean = (ST_b6d345dd13582e4e92d7108f300179feStructure)this.ssSTBoolean.Duplicate();
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
if (head == "boolean") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Boolean")) variable.Value = ssSTBoolean; else variable.Optimized = true;
variable.SetFieldName("boolean");
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
if (key == IdBoolean) {
return ssSTBoolean;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdBoolean.Key.AsGuid) {
return ssSTBoolean;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTBoolean.FillFromOther((IRecord) other.AttributeGet(IdBoolean));
}
} // RC_d200060d081b41826672020864051a96
/// <summary>
/// RecordList type <code>BooleanRecordList</code> that represents a record list of
///  <code>Boolean</code>
/// </summary>
public partial class RL_4d7daf097728c366f694195b8c94a4db : GenericRecordList<RC_d200060d081b41826672020864051a96>, IEnumerable, IEnumerator {

protected override RC_d200060d081b41826672020864051a96 GetElementDefaultValue() {
return new RC_d200060d081b41826672020864051a96();
}

public T[] ToArray<T>(Func<RC_d200060d081b41826672020864051a96, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_4d7daf097728c366f694195b8c94a4db recordList, Func<RC_d200060d081b41826672020864051a96, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_4d7daf097728c366f694195b8c94a4db(RC_d200060d081b41826672020864051a96[] array) {
  RL_4d7daf097728c366f694195b8c94a4db result = new RL_4d7daf097728c366f694195b8c94a4db();
result.InnerFromArray(array);
    return result;
}

public static RL_4d7daf097728c366f694195b8c94a4db ToList<T>(T[] array, Func <T, RC_d200060d081b41826672020864051a96> converter) {
  RL_4d7daf097728c366f694195b8c94a4db result = new RL_4d7daf097728c366f694195b8c94a4db();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_4d7daf097728c366f694195b8c94a4db FromRestList<T>(RestList<T> restList, Func <T, RC_d200060d081b41826672020864051a96> converter) {
  RL_4d7daf097728c366f694195b8c94a4db result = new RL_4d7daf097728c366f694195b8c94a4db();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_4d7daf097728c366f694195b8c94a4db() : base() {
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
protected override OSList<RC_d200060d081b41826672020864051a96> NewList() {
return new RL_4d7daf097728c366f694195b8c94a4db();
}


} // RL_4d7daf097728c366f694195b8c94a4db
}

