namespace ssConectaProveedores {
/// <summary>
/// [Structure] LongIntegerIdentifier (ddtRHJig+E+mw+shiLY3Xw)
///  <code>ST_52a0b4b2bb66d62c40848f2d472a3986Structure</code> that represent
/// s <code>LongIntegerIdentifier</code> <p>Description: </p>
/// </summary>
// Name: LongIntegerIdentifier
public partial struct ST_52a0b4b2bb66d62c40848f2d472a3986Structure : ITypedRecord<ST_52a0b4b2bb66d62c40848f2d472a3986Structure> {
internal static readonly GlobalObjectKey IdValue = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*iRjUwlFwYkmDGaK1u0brpQ");

public long ssValue;


public BitArray OptimizedAttributes;

public ST_52a0b4b2bb66d62c40848f2d472a3986Structure() {
OptimizedAttributes = null;
ssValue = Convert.ToInt64(0);
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[0];
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    }else{
    }
}
get{
    BitArray[] all = new BitArray[0];
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssValue = r.ReadLongInteger(index++, "LongIntegerIdentifier.Value", 0L);
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
public void ReadIM(ST_52a0b4b2bb66d62c40848f2d472a3986Structure r) {
this = r;
}


public static bool operator == (ST_52a0b4b2bb66d62c40848f2d472a3986Structure a, ST_52a0b4b2bb66d62c40848f2d472a3986Structure b) {
if (a.ssValue != b.ssValue) return false;
return true;
}

public static bool operator != (ST_52a0b4b2bb66d62c40848f2d472a3986Structure a, ST_52a0b4b2bb66d62c40848f2d472a3986Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_52a0b4b2bb66d62c40848f2d472a3986Structure)) return false;
return (this == (ST_52a0b4b2bb66d62c40848f2d472a3986Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssValue.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_52a0b4b2bb66d62c40848f2d472a3986Structure Duplicate() {
ST_52a0b4b2bb66d62c40848f2d472a3986Structure t;
t.ssValue = this.ssValue;
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
if (head == "value") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Value")) variable.Value = ssValue; else variable.Optimized = true;
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
if (key == IdValue) {
return ssValue;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdValue.Key.AsGuid) {
return ssValue;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssValue = (long) other.AttributeGet(IdValue);
}
} // ST_52a0b4b2bb66d62c40848f2d472a3986Structure
/// <summary>
/// RecordList type <code>LongIntegerIdentifierList</code> that represents a record list of
///  <code>LongIntegerIdentifier</code>
/// </summary>
public partial class RL_01b8e48c13b44db19a2b5e680be8125a : GenericRecordList<ST_52a0b4b2bb66d62c40848f2d472a3986Structure>, IEnumerable, IEnumerator {

protected override ST_52a0b4b2bb66d62c40848f2d472a3986Structure GetElementDefaultValue() {
return new ST_52a0b4b2bb66d62c40848f2d472a3986Structure();
}

public T[] ToArray<T>(Func<ST_52a0b4b2bb66d62c40848f2d472a3986Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_01b8e48c13b44db19a2b5e680be8125a recordList, Func<ST_52a0b4b2bb66d62c40848f2d472a3986Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_01b8e48c13b44db19a2b5e680be8125a(ST_52a0b4b2bb66d62c40848f2d472a3986Structure[] array) {
  RL_01b8e48c13b44db19a2b5e680be8125a result = new RL_01b8e48c13b44db19a2b5e680be8125a();
result.InnerFromArray(array);
    return result;
}

public static RL_01b8e48c13b44db19a2b5e680be8125a ToList<T>(T[] array, Func <T, ST_52a0b4b2bb66d62c40848f2d472a3986Structure> converter) {
  RL_01b8e48c13b44db19a2b5e680be8125a result = new RL_01b8e48c13b44db19a2b5e680be8125a();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_01b8e48c13b44db19a2b5e680be8125a FromRestList<T>(RestList<T> restList, Func <T, ST_52a0b4b2bb66d62c40848f2d472a3986Structure> converter) {
  RL_01b8e48c13b44db19a2b5e680be8125a result = new RL_01b8e48c13b44db19a2b5e680be8125a();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_01b8e48c13b44db19a2b5e680be8125a() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_52a0b4b2bb66d62c40848f2d472a3986Structure> NewList() {
return new RL_01b8e48c13b44db19a2b5e680be8125a();
}


} // RL_01b8e48c13b44db19a2b5e680be8125a
}

