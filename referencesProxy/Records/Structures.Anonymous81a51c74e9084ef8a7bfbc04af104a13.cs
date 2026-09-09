namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (dBylgQjp+E6nv7wErxBKEw)
///  <code>RC_87ab3d0b80938e4e95dcb616c8a9232e</code> that represents <code>DataPointRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: DataPointRecord
public partial struct RC_87ab3d0b80938e4e95dcb616c8a9232e : ITypedRecord<RC_87ab3d0b80938e4e95dcb616c8a9232e> {
internal static readonly GlobalObjectKey IdDataPoint = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*Cz2rh5OATo6V3LYWyKkjLg");

public ST_34313c5cf94d7ce3c5404858c22fafd9Structure ssSTDataPoint;


public static implicit operator ST_34313c5cf94d7ce3c5404858c22fafd9Structure( RC_87ab3d0b80938e4e95dcb616c8a9232e r) {
return r.ssSTDataPoint;
}

public static implicit operator RC_87ab3d0b80938e4e95dcb616c8a9232e (ST_34313c5cf94d7ce3c5404858c22fafd9Structure r) {
RC_87ab3d0b80938e4e95dcb616c8a9232e res = new RC_87ab3d0b80938e4e95dcb616c8a9232e ();
res.ssSTDataPoint = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_87ab3d0b80938e4e95dcb616c8a9232e() {
OptimizedAttributes = null;
ssSTDataPoint = new ST_34313c5cf94d7ce3c5404858c22fafd9Structure();
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
    ssSTDataPoint.OptimizedAttributes = value[0];
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
ssSTDataPoint.Read( r, ref index);
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
public void ReadIM(RC_87ab3d0b80938e4e95dcb616c8a9232e r) {
this = r;
}


public static bool operator == (RC_87ab3d0b80938e4e95dcb616c8a9232e a, RC_87ab3d0b80938e4e95dcb616c8a9232e b) {
if (a.ssSTDataPoint != b.ssSTDataPoint) return false;
return true;
}

public static bool operator != (RC_87ab3d0b80938e4e95dcb616c8a9232e a, RC_87ab3d0b80938e4e95dcb616c8a9232e b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_87ab3d0b80938e4e95dcb616c8a9232e)) return false;
return (this == (RC_87ab3d0b80938e4e95dcb616c8a9232e)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTDataPoint.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTDataPoint.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTDataPoint.InternalRecursiveSave();
}


public RC_87ab3d0b80938e4e95dcb616c8a9232e Duplicate() {
RC_87ab3d0b80938e4e95dcb616c8a9232e t;
t.ssSTDataPoint = (ST_34313c5cf94d7ce3c5404858c22fafd9Structure)this.ssSTDataPoint.Duplicate();
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
if (head == "datapoint") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".DataPoint")) variable.Value = ssSTDataPoint; else variable.Optimized = true;
variable.SetFieldName("datapoint");
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
if (key == IdDataPoint) {
return ssSTDataPoint;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdDataPoint.Key.AsGuid) {
return ssSTDataPoint;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTDataPoint.FillFromOther((IRecord) other.AttributeGet(IdDataPoint));
}
} // RC_87ab3d0b80938e4e95dcb616c8a9232e
/// <summary>
/// RecordList type <code>DataPointRecordList</code> that represents a record list of
///  <code>DataPoint</code>
/// </summary>
public partial class RL_6a352f2318cfd62ff903ae77454721c8 : GenericRecordList<RC_87ab3d0b80938e4e95dcb616c8a9232e>, IEnumerable, IEnumerator {

protected override RC_87ab3d0b80938e4e95dcb616c8a9232e GetElementDefaultValue() {
return new RC_87ab3d0b80938e4e95dcb616c8a9232e();
}

public T[] ToArray<T>(Func<RC_87ab3d0b80938e4e95dcb616c8a9232e, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_6a352f2318cfd62ff903ae77454721c8 recordList, Func<RC_87ab3d0b80938e4e95dcb616c8a9232e, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_6a352f2318cfd62ff903ae77454721c8(RC_87ab3d0b80938e4e95dcb616c8a9232e[] array) {
  RL_6a352f2318cfd62ff903ae77454721c8 result = new RL_6a352f2318cfd62ff903ae77454721c8();
result.InnerFromArray(array);
    return result;
}

public static RL_6a352f2318cfd62ff903ae77454721c8 ToList<T>(T[] array, Func <T, RC_87ab3d0b80938e4e95dcb616c8a9232e> converter) {
  RL_6a352f2318cfd62ff903ae77454721c8 result = new RL_6a352f2318cfd62ff903ae77454721c8();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_6a352f2318cfd62ff903ae77454721c8 FromRestList<T>(RestList<T> restList, Func <T, RC_87ab3d0b80938e4e95dcb616c8a9232e> converter) {
  RL_6a352f2318cfd62ff903ae77454721c8 result = new RL_6a352f2318cfd62ff903ae77454721c8();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_6a352f2318cfd62ff903ae77454721c8() : base() {
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
protected override OSList<RC_87ab3d0b80938e4e95dcb616c8a9232e> NewList() {
return new RL_6a352f2318cfd62ff903ae77454721c8();
}


} // RL_6a352f2318cfd62ff903ae77454721c8
}

