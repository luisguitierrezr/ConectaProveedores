namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (1l+bByCDwEq5rbQXFqm4sA)
///  <code>RC_1cda0f8d3a174e3a7f752b5be5436b83</code> that represents <code>OrderTempRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: OrderTempRecord
public partial struct RC_1cda0f8d3a174e3a7f752b5be5436b83 : ITypedRecord<RC_1cda0f8d3a174e3a7f752b5be5436b83> {
internal static readonly GlobalObjectKey IdOrderTemp = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*jQ_aHBc6Ok5_dStb5UNrgw");

public ST_9b020d447acc32d28b5e58ce81130d00Structure ssSTOrderTemp;


public static implicit operator ST_9b020d447acc32d28b5e58ce81130d00Structure( RC_1cda0f8d3a174e3a7f752b5be5436b83 r) {
return r.ssSTOrderTemp;
}

public static implicit operator RC_1cda0f8d3a174e3a7f752b5be5436b83 (ST_9b020d447acc32d28b5e58ce81130d00Structure r) {
RC_1cda0f8d3a174e3a7f752b5be5436b83 res = new RC_1cda0f8d3a174e3a7f752b5be5436b83 ();
res.ssSTOrderTemp = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_1cda0f8d3a174e3a7f752b5be5436b83() {
OptimizedAttributes = null;
ssSTOrderTemp = new ST_9b020d447acc32d28b5e58ce81130d00Structure();
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
    ssSTOrderTemp.OptimizedAttributes = value[0];
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
ssSTOrderTemp.Read( r, ref index);
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
public void ReadIM(RC_1cda0f8d3a174e3a7f752b5be5436b83 r) {
this = r;
}


public static bool operator == (RC_1cda0f8d3a174e3a7f752b5be5436b83 a, RC_1cda0f8d3a174e3a7f752b5be5436b83 b) {
if (a.ssSTOrderTemp != b.ssSTOrderTemp) return false;
return true;
}

public static bool operator != (RC_1cda0f8d3a174e3a7f752b5be5436b83 a, RC_1cda0f8d3a174e3a7f752b5be5436b83 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_1cda0f8d3a174e3a7f752b5be5436b83)) return false;
return (this == (RC_1cda0f8d3a174e3a7f752b5be5436b83)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTOrderTemp.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTOrderTemp.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTOrderTemp.InternalRecursiveSave();
}


public RC_1cda0f8d3a174e3a7f752b5be5436b83 Duplicate() {
RC_1cda0f8d3a174e3a7f752b5be5436b83 t;
t.ssSTOrderTemp = (ST_9b020d447acc32d28b5e58ce81130d00Structure)this.ssSTOrderTemp.Duplicate();
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
if (head == "ordertemp") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderTemp")) variable.Value = ssSTOrderTemp; else variable.Optimized = true;
variable.SetFieldName("ordertemp");
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
if (key == IdOrderTemp) {
return ssSTOrderTemp;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdOrderTemp.Key.AsGuid) {
return ssSTOrderTemp;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTOrderTemp.FillFromOther((IRecord) other.AttributeGet(IdOrderTemp));
}
} // RC_1cda0f8d3a174e3a7f752b5be5436b83
/// <summary>
/// RecordList type <code>OrderTempRecordList</code> that represents a record list of
///  <code>OrderTemp</code>
/// </summary>
public partial class RL_a21dd06b5dc9838837959eab023af4ca : GenericRecordList<RC_1cda0f8d3a174e3a7f752b5be5436b83>, IEnumerable, IEnumerator {

protected override RC_1cda0f8d3a174e3a7f752b5be5436b83 GetElementDefaultValue() {
return new RC_1cda0f8d3a174e3a7f752b5be5436b83();
}

public T[] ToArray<T>(Func<RC_1cda0f8d3a174e3a7f752b5be5436b83, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_a21dd06b5dc9838837959eab023af4ca recordList, Func<RC_1cda0f8d3a174e3a7f752b5be5436b83, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_a21dd06b5dc9838837959eab023af4ca(RC_1cda0f8d3a174e3a7f752b5be5436b83[] array) {
  RL_a21dd06b5dc9838837959eab023af4ca result = new RL_a21dd06b5dc9838837959eab023af4ca();
result.InnerFromArray(array);
    return result;
}

public static RL_a21dd06b5dc9838837959eab023af4ca ToList<T>(T[] array, Func <T, RC_1cda0f8d3a174e3a7f752b5be5436b83> converter) {
  RL_a21dd06b5dc9838837959eab023af4ca result = new RL_a21dd06b5dc9838837959eab023af4ca();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_a21dd06b5dc9838837959eab023af4ca FromRestList<T>(RestList<T> restList, Func <T, RC_1cda0f8d3a174e3a7f752b5be5436b83> converter) {
  RL_a21dd06b5dc9838837959eab023af4ca result = new RL_a21dd06b5dc9838837959eab023af4ca();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_a21dd06b5dc9838837959eab023af4ca() : base() {
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
protected override OSList<RC_1cda0f8d3a174e3a7f752b5be5436b83> NewList() {
return new RL_a21dd06b5dc9838837959eab023af4ca();
}


} // RL_a21dd06b5dc9838837959eab023af4ca
}

