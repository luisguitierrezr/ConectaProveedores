namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (0R3xrF5D80OdvmVg511EGw)
///  <code>RC_29144121e66fe3c5dd5540583acfd891</code> that represents <code>Output2Record</code
/// > <p>Description: </p>
/// </summary>
// Name: Output2Record
public partial struct RC_29144121e66fe3c5dd5540583acfd891 : ITypedRecord<RC_29144121e66fe3c5dd5540583acfd891> {
internal static readonly GlobalObjectKey IdOutput2 = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*IUEUKW_mxePdVUBYOs_YkQ");

public ST_346a76e47f982dbf41625f8a893affccStructure ssSTOutput2;


public static implicit operator ST_346a76e47f982dbf41625f8a893affccStructure( RC_29144121e66fe3c5dd5540583acfd891 r) {
return r.ssSTOutput2;
}

public static implicit operator RC_29144121e66fe3c5dd5540583acfd891 (ST_346a76e47f982dbf41625f8a893affccStructure r) {
RC_29144121e66fe3c5dd5540583acfd891 res = new RC_29144121e66fe3c5dd5540583acfd891 ();
res.ssSTOutput2 = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_29144121e66fe3c5dd5540583acfd891() {
OptimizedAttributes = null;
ssSTOutput2 = new ST_346a76e47f982dbf41625f8a893affccStructure();
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
    ssSTOutput2.OptimizedAttributes = value[0];
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
ssSTOutput2.Read( r, ref index);
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
public void ReadIM(RC_29144121e66fe3c5dd5540583acfd891 r) {
this = r;
}


public static bool operator == (RC_29144121e66fe3c5dd5540583acfd891 a, RC_29144121e66fe3c5dd5540583acfd891 b) {
if (a.ssSTOutput2 != b.ssSTOutput2) return false;
return true;
}

public static bool operator != (RC_29144121e66fe3c5dd5540583acfd891 a, RC_29144121e66fe3c5dd5540583acfd891 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_29144121e66fe3c5dd5540583acfd891)) return false;
return (this == (RC_29144121e66fe3c5dd5540583acfd891)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTOutput2.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTOutput2.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTOutput2.InternalRecursiveSave();
}


public RC_29144121e66fe3c5dd5540583acfd891 Duplicate() {
RC_29144121e66fe3c5dd5540583acfd891 t;
t.ssSTOutput2 = (ST_346a76e47f982dbf41625f8a893affccStructure)this.ssSTOutput2.Duplicate();
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
if (head == "output2") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Output2")) variable.Value = ssSTOutput2; else variable.Optimized = true;
variable.SetFieldName("output2");
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
if (key == IdOutput2) {
return ssSTOutput2;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdOutput2.Key.AsGuid) {
return ssSTOutput2;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTOutput2.FillFromOther((IRecord) other.AttributeGet(IdOutput2));
}
} // RC_29144121e66fe3c5dd5540583acfd891
/// <summary>
/// RecordList type <code>Output2RecordList</code> that represents a record list of
///  <code>Output2</code>
/// </summary>
public partial class RL_59975b845e905d3bcefad292f1a206c9 : GenericRecordList<RC_29144121e66fe3c5dd5540583acfd891>, IEnumerable, IEnumerator {

protected override RC_29144121e66fe3c5dd5540583acfd891 GetElementDefaultValue() {
return new RC_29144121e66fe3c5dd5540583acfd891();
}

public T[] ToArray<T>(Func<RC_29144121e66fe3c5dd5540583acfd891, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_59975b845e905d3bcefad292f1a206c9 recordList, Func<RC_29144121e66fe3c5dd5540583acfd891, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_59975b845e905d3bcefad292f1a206c9(RC_29144121e66fe3c5dd5540583acfd891[] array) {
  RL_59975b845e905d3bcefad292f1a206c9 result = new RL_59975b845e905d3bcefad292f1a206c9();
result.InnerFromArray(array);
    return result;
}

public static RL_59975b845e905d3bcefad292f1a206c9 ToList<T>(T[] array, Func <T, RC_29144121e66fe3c5dd5540583acfd891> converter) {
  RL_59975b845e905d3bcefad292f1a206c9 result = new RL_59975b845e905d3bcefad292f1a206c9();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_59975b845e905d3bcefad292f1a206c9 FromRestList<T>(RestList<T> restList, Func <T, RC_29144121e66fe3c5dd5540583acfd891> converter) {
  RL_59975b845e905d3bcefad292f1a206c9 result = new RL_59975b845e905d3bcefad292f1a206c9();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_59975b845e905d3bcefad292f1a206c9() : base() {
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
protected override OSList<RC_29144121e66fe3c5dd5540583acfd891> NewList() {
return new RL_59975b845e905d3bcefad292f1a206c9();
}


} // RL_59975b845e905d3bcefad292f1a206c9
}

