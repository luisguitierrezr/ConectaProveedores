namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (XAUz8GZ7xU6HGhCEoNfsbA)
///  <code>RC_5c3ac3a9ea8d123d893bbdf956320e53</code> that represents <code>PI_HEADER_MORecord</code
/// > <p>Description: </p>
/// </summary>
// Name: PI_HEADER_MORecord
public partial struct RC_5c3ac3a9ea8d123d893bbdf956320e53 : ITypedRecord<RC_5c3ac3a9ea8d123d893bbdf956320e53> {
internal static readonly GlobalObjectKey IdPI_HEADER_MO = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*qcM6XI3qPRKJO735VjIOUw");

public ST_16a23b6e422231c222f34612ecd6c640Structure ssSTPI_HEADER_MO;


public static implicit operator ST_16a23b6e422231c222f34612ecd6c640Structure( RC_5c3ac3a9ea8d123d893bbdf956320e53 r) {
return r.ssSTPI_HEADER_MO;
}

public static implicit operator RC_5c3ac3a9ea8d123d893bbdf956320e53 (ST_16a23b6e422231c222f34612ecd6c640Structure r) {
RC_5c3ac3a9ea8d123d893bbdf956320e53 res = new RC_5c3ac3a9ea8d123d893bbdf956320e53 ();
res.ssSTPI_HEADER_MO = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_5c3ac3a9ea8d123d893bbdf956320e53() {
OptimizedAttributes = null;
ssSTPI_HEADER_MO = new ST_16a23b6e422231c222f34612ecd6c640Structure();
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
    ssSTPI_HEADER_MO.OptimizedAttributes = value[0];
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
ssSTPI_HEADER_MO.Read( r, ref index);
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
public void ReadIM(RC_5c3ac3a9ea8d123d893bbdf956320e53 r) {
this = r;
}


public static bool operator == (RC_5c3ac3a9ea8d123d893bbdf956320e53 a, RC_5c3ac3a9ea8d123d893bbdf956320e53 b) {
if (a.ssSTPI_HEADER_MO != b.ssSTPI_HEADER_MO) return false;
return true;
}

public static bool operator != (RC_5c3ac3a9ea8d123d893bbdf956320e53 a, RC_5c3ac3a9ea8d123d893bbdf956320e53 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_5c3ac3a9ea8d123d893bbdf956320e53)) return false;
return (this == (RC_5c3ac3a9ea8d123d893bbdf956320e53)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTPI_HEADER_MO.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTPI_HEADER_MO.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTPI_HEADER_MO.InternalRecursiveSave();
}


public RC_5c3ac3a9ea8d123d893bbdf956320e53 Duplicate() {
RC_5c3ac3a9ea8d123d893bbdf956320e53 t;
t.ssSTPI_HEADER_MO = (ST_16a23b6e422231c222f34612ecd6c640Structure)this.ssSTPI_HEADER_MO.Duplicate();
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
if (head == "pi_header_mo") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PI_HEADER_MO")) variable.Value = ssSTPI_HEADER_MO; else variable.Optimized = true;
variable.SetFieldName("pi_header_mo");
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
if (key == IdPI_HEADER_MO) {
return ssSTPI_HEADER_MO;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdPI_HEADER_MO.Key.AsGuid) {
return ssSTPI_HEADER_MO;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTPI_HEADER_MO.FillFromOther((IRecord) other.AttributeGet(IdPI_HEADER_MO));
}
} // RC_5c3ac3a9ea8d123d893bbdf956320e53
/// <summary>
/// RecordList type <code>PI_HEADER_MORecordList</code> that represents a record list of
///  <code>PI_HEADER_MO</code>
/// </summary>
public partial class RL_11185d6414176f221a065641f9333414 : GenericRecordList<RC_5c3ac3a9ea8d123d893bbdf956320e53>, IEnumerable, IEnumerator {

protected override RC_5c3ac3a9ea8d123d893bbdf956320e53 GetElementDefaultValue() {
return new RC_5c3ac3a9ea8d123d893bbdf956320e53();
}

public T[] ToArray<T>(Func<RC_5c3ac3a9ea8d123d893bbdf956320e53, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_11185d6414176f221a065641f9333414 recordList, Func<RC_5c3ac3a9ea8d123d893bbdf956320e53, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_11185d6414176f221a065641f9333414(RC_5c3ac3a9ea8d123d893bbdf956320e53[] array) {
  RL_11185d6414176f221a065641f9333414 result = new RL_11185d6414176f221a065641f9333414();
result.InnerFromArray(array);
    return result;
}

public static RL_11185d6414176f221a065641f9333414 ToList<T>(T[] array, Func <T, RC_5c3ac3a9ea8d123d893bbdf956320e53> converter) {
  RL_11185d6414176f221a065641f9333414 result = new RL_11185d6414176f221a065641f9333414();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_11185d6414176f221a065641f9333414 FromRestList<T>(RestList<T> restList, Func <T, RC_5c3ac3a9ea8d123d893bbdf956320e53> converter) {
  RL_11185d6414176f221a065641f9333414 result = new RL_11185d6414176f221a065641f9333414();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_11185d6414176f221a065641f9333414() : base() {
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
protected override OSList<RC_5c3ac3a9ea8d123d893bbdf956320e53> NewList() {
return new RL_11185d6414176f221a065641f9333414();
}


} // RL_11185d6414176f221a065641f9333414
}

