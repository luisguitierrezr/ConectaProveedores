namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (8a8v3I4JDEaa7vhGyW8EJg)
///  <code>RC_b7a8ca64723e51be7fabec3ceba0b1cb</code> that represent
/// s <code>GetGroupsResponseRecord</code> <p>Description: </p>
/// </summary>
// Name: GetGroupsResponseRecord
public partial struct RC_b7a8ca64723e51be7fabec3ceba0b1cb : ITypedRecord<RC_b7a8ca64723e51be7fabec3ceba0b1cb> {
internal static readonly GlobalObjectKey IdGetGroupsResponse = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*ZMqotz5yvlF_q+w866Cxyw");

public ST_d3e1050921d01f07c3bdfba3f3e6e343Structure ssSTGetGroupsResponse;


public static implicit operator ST_d3e1050921d01f07c3bdfba3f3e6e343Structure( RC_b7a8ca64723e51be7fabec3ceba0b1cb r) {
return r.ssSTGetGroupsResponse;
}

public static implicit operator RC_b7a8ca64723e51be7fabec3ceba0b1cb (ST_d3e1050921d01f07c3bdfba3f3e6e343Structure r) {
RC_b7a8ca64723e51be7fabec3ceba0b1cb res = new RC_b7a8ca64723e51be7fabec3ceba0b1cb ();
res.ssSTGetGroupsResponse = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_b7a8ca64723e51be7fabec3ceba0b1cb() {
OptimizedAttributes = null;
ssSTGetGroupsResponse = new ST_d3e1050921d01f07c3bdfba3f3e6e343Structure();
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
    ssSTGetGroupsResponse.OptimizedAttributes = value[0];
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
ssSTGetGroupsResponse.Read( r, ref index);
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
public void ReadIM(RC_b7a8ca64723e51be7fabec3ceba0b1cb r) {
this = r;
}


public static bool operator == (RC_b7a8ca64723e51be7fabec3ceba0b1cb a, RC_b7a8ca64723e51be7fabec3ceba0b1cb b) {
if (a.ssSTGetGroupsResponse != b.ssSTGetGroupsResponse) return false;
return true;
}

public static bool operator != (RC_b7a8ca64723e51be7fabec3ceba0b1cb a, RC_b7a8ca64723e51be7fabec3ceba0b1cb b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_b7a8ca64723e51be7fabec3ceba0b1cb)) return false;
return (this == (RC_b7a8ca64723e51be7fabec3ceba0b1cb)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTGetGroupsResponse.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTGetGroupsResponse.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTGetGroupsResponse.InternalRecursiveSave();
}


public RC_b7a8ca64723e51be7fabec3ceba0b1cb Duplicate() {
RC_b7a8ca64723e51be7fabec3ceba0b1cb t;
t.ssSTGetGroupsResponse = (ST_d3e1050921d01f07c3bdfba3f3e6e343Structure)this.ssSTGetGroupsResponse.Duplicate();
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
if (head == "getgroupsresponse") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".GetGroupsResponse")) variable.Value = ssSTGetGroupsResponse; else variable.Optimized = true;
variable.SetFieldName("getgroupsresponse");
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
if (key == IdGetGroupsResponse) {
return ssSTGetGroupsResponse;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdGetGroupsResponse.Key.AsGuid) {
return ssSTGetGroupsResponse;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTGetGroupsResponse.FillFromOther((IRecord) other.AttributeGet(IdGetGroupsResponse));
}
} // RC_b7a8ca64723e51be7fabec3ceba0b1cb
/// <summary>
/// RecordList type <code>GetGroupsResponseRecordList</code> that represents a record list of
///  <code>GetGroupsResponse</code>
/// </summary>
public partial class RL_e3d5d77c2a28664536fbb66520323edc : GenericRecordList<RC_b7a8ca64723e51be7fabec3ceba0b1cb>, IEnumerable, IEnumerator {

protected override RC_b7a8ca64723e51be7fabec3ceba0b1cb GetElementDefaultValue() {
return new RC_b7a8ca64723e51be7fabec3ceba0b1cb();
}

public T[] ToArray<T>(Func<RC_b7a8ca64723e51be7fabec3ceba0b1cb, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_e3d5d77c2a28664536fbb66520323edc recordList, Func<RC_b7a8ca64723e51be7fabec3ceba0b1cb, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_e3d5d77c2a28664536fbb66520323edc(RC_b7a8ca64723e51be7fabec3ceba0b1cb[] array) {
  RL_e3d5d77c2a28664536fbb66520323edc result = new RL_e3d5d77c2a28664536fbb66520323edc();
result.InnerFromArray(array);
    return result;
}

public static RL_e3d5d77c2a28664536fbb66520323edc ToList<T>(T[] array, Func <T, RC_b7a8ca64723e51be7fabec3ceba0b1cb> converter) {
  RL_e3d5d77c2a28664536fbb66520323edc result = new RL_e3d5d77c2a28664536fbb66520323edc();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_e3d5d77c2a28664536fbb66520323edc FromRestList<T>(RestList<T> restList, Func <T, RC_b7a8ca64723e51be7fabec3ceba0b1cb> converter) {
  RL_e3d5d77c2a28664536fbb66520323edc result = new RL_e3d5d77c2a28664536fbb66520323edc();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_e3d5d77c2a28664536fbb66520323edc() : base() {
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
protected override OSList<RC_b7a8ca64723e51be7fabec3ceba0b1cb> NewList() {
return new RL_e3d5d77c2a28664536fbb66520323edc();
}


} // RL_e3d5d77c2a28664536fbb66520323edc
}

