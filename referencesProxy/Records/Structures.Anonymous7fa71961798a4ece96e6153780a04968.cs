namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (YRmnf4p5zk6W5hU3gKBJaA)
///  <code>RC_2a95beba087a746fe5db4671c0cbdf13</code> that represent
/// s <code>EM_COSMOZ_Request_StructRecord</code> <p>Description: </p>
/// </summary>
// Name: EM_COSMOZ_Request_StructRecord
public partial struct RC_2a95beba087a746fe5db4671c0cbdf13 : ITypedRecord<RC_2a95beba087a746fe5db4671c0cbdf13> {
internal static readonly GlobalObjectKey IdEM_COSMOZ_Request_Struct = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*ur6VKnoIb3Tl20ZxwMvfEw");

public ST_54b441362fa983751bf9575ed6b668beStructure ssSTEM_COSMOZ_Request_Struct;


public static implicit operator ST_54b441362fa983751bf9575ed6b668beStructure( RC_2a95beba087a746fe5db4671c0cbdf13 r) {
return r.ssSTEM_COSMOZ_Request_Struct;
}

public static implicit operator RC_2a95beba087a746fe5db4671c0cbdf13 (ST_54b441362fa983751bf9575ed6b668beStructure r) {
RC_2a95beba087a746fe5db4671c0cbdf13 res = new RC_2a95beba087a746fe5db4671c0cbdf13 ();
res.ssSTEM_COSMOZ_Request_Struct = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_2a95beba087a746fe5db4671c0cbdf13() {
OptimizedAttributes = null;
ssSTEM_COSMOZ_Request_Struct = new ST_54b441362fa983751bf9575ed6b668beStructure();
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
    ssSTEM_COSMOZ_Request_Struct.OptimizedAttributes = value[0];
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
ssSTEM_COSMOZ_Request_Struct.Read( r, ref index);
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
public void ReadIM(RC_2a95beba087a746fe5db4671c0cbdf13 r) {
this = r;
}


public static bool operator == (RC_2a95beba087a746fe5db4671c0cbdf13 a, RC_2a95beba087a746fe5db4671c0cbdf13 b) {
if (a.ssSTEM_COSMOZ_Request_Struct != b.ssSTEM_COSMOZ_Request_Struct) return false;
return true;
}

public static bool operator != (RC_2a95beba087a746fe5db4671c0cbdf13 a, RC_2a95beba087a746fe5db4671c0cbdf13 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_2a95beba087a746fe5db4671c0cbdf13)) return false;
return (this == (RC_2a95beba087a746fe5db4671c0cbdf13)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTEM_COSMOZ_Request_Struct.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTEM_COSMOZ_Request_Struct.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTEM_COSMOZ_Request_Struct.InternalRecursiveSave();
}


public RC_2a95beba087a746fe5db4671c0cbdf13 Duplicate() {
RC_2a95beba087a746fe5db4671c0cbdf13 t;
t.ssSTEM_COSMOZ_Request_Struct = (ST_54b441362fa983751bf9575ed6b668beStructure)this.ssSTEM_COSMOZ_Request_Struct.Duplicate();
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
if (head == "em_cosmoz_request_struct") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".EM_COSMOZ_Request_Struct")) variable.Value = ssSTEM_COSMOZ_Request_Struct; else variable.Optimized = true;
variable.SetFieldName("em_cosmoz_request_struct");
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
if (key == IdEM_COSMOZ_Request_Struct) {
return ssSTEM_COSMOZ_Request_Struct;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdEM_COSMOZ_Request_Struct.Key.AsGuid) {
return ssSTEM_COSMOZ_Request_Struct;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTEM_COSMOZ_Request_Struct.FillFromOther((IRecord) other.AttributeGet(IdEM_COSMOZ_Request_Struct));
}
} // RC_2a95beba087a746fe5db4671c0cbdf13
/// <summary>
/// RecordList type <code>EM_COSMOZ_Request_StructRecordList</code> that represents a record list of
///  <code>EM_COSMOZ_Request_Struct</code>
/// </summary>
public partial class RL_3565a49de097530da9a63d053c54567c : GenericRecordList<RC_2a95beba087a746fe5db4671c0cbdf13>, IEnumerable, IEnumerator {

protected override RC_2a95beba087a746fe5db4671c0cbdf13 GetElementDefaultValue() {
return new RC_2a95beba087a746fe5db4671c0cbdf13();
}

public T[] ToArray<T>(Func<RC_2a95beba087a746fe5db4671c0cbdf13, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_3565a49de097530da9a63d053c54567c recordList, Func<RC_2a95beba087a746fe5db4671c0cbdf13, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_3565a49de097530da9a63d053c54567c(RC_2a95beba087a746fe5db4671c0cbdf13[] array) {
  RL_3565a49de097530da9a63d053c54567c result = new RL_3565a49de097530da9a63d053c54567c();
result.InnerFromArray(array);
    return result;
}

public static RL_3565a49de097530da9a63d053c54567c ToList<T>(T[] array, Func <T, RC_2a95beba087a746fe5db4671c0cbdf13> converter) {
  RL_3565a49de097530da9a63d053c54567c result = new RL_3565a49de097530da9a63d053c54567c();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_3565a49de097530da9a63d053c54567c FromRestList<T>(RestList<T> restList, Func <T, RC_2a95beba087a746fe5db4671c0cbdf13> converter) {
  RL_3565a49de097530da9a63d053c54567c result = new RL_3565a49de097530da9a63d053c54567c();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_3565a49de097530da9a63d053c54567c() : base() {
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
protected override OSList<RC_2a95beba087a746fe5db4671c0cbdf13> NewList() {
return new RL_3565a49de097530da9a63d053c54567c();
}


} // RL_3565a49de097530da9a63d053c54567c
}

