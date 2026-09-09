namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (6RY2tC88+EOw3yx+kutDLA)
///  <code>RC_2407b5abb2cbfeaeaa8da6cdea4ccf12</code> that represent
/// s <code>OrdersImportRequestRecord</code> <p>Description: </p>
/// </summary>
// Name: OrdersImportRequestRecord
public partial struct RC_2407b5abb2cbfeaeaa8da6cdea4ccf12 : ITypedRecord<RC_2407b5abb2cbfeaeaa8da6cdea4ccf12> {
internal static readonly GlobalObjectKey IdOrdersImportRequest = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*q7UHJMuyrv6qjabN6kzPEg");

public EN_8c3668a93870461b8ea1216c2848f298EntityRecord ssENOrdersImportRequest;


public static implicit operator EN_8c3668a93870461b8ea1216c2848f298EntityRecord( RC_2407b5abb2cbfeaeaa8da6cdea4ccf12 r) {
return r.ssENOrdersImportRequest;
}

public static implicit operator RC_2407b5abb2cbfeaeaa8da6cdea4ccf12 (EN_8c3668a93870461b8ea1216c2848f298EntityRecord r) {
RC_2407b5abb2cbfeaeaa8da6cdea4ccf12 res = new RC_2407b5abb2cbfeaeaa8da6cdea4ccf12 ();
res.ssENOrdersImportRequest = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENOrdersImportRequest.ChangedAttributes = value;
}
get {
    return ssENOrdersImportRequest.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_2407b5abb2cbfeaeaa8da6cdea4ccf12() {
OptimizedAttributes = null;
ssENOrdersImportRequest = new EN_8c3668a93870461b8ea1216c2848f298EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(10,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENOrdersImportRequest.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENOrdersImportRequest.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENOrdersImportRequest.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENOrdersImportRequest.Read( r, ref index);
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
public void ReadIM(RC_2407b5abb2cbfeaeaa8da6cdea4ccf12 r) {
this = r;
}


public static bool operator == (RC_2407b5abb2cbfeaeaa8da6cdea4ccf12 a, RC_2407b5abb2cbfeaeaa8da6cdea4ccf12 b) {
if (a.ssENOrdersImportRequest != b.ssENOrdersImportRequest) return false;
return true;
}

public static bool operator != (RC_2407b5abb2cbfeaeaa8da6cdea4ccf12 a, RC_2407b5abb2cbfeaeaa8da6cdea4ccf12 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_2407b5abb2cbfeaeaa8da6cdea4ccf12)) return false;
return (this == (RC_2407b5abb2cbfeaeaa8da6cdea4ccf12)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENOrdersImportRequest.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENOrdersImportRequest.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENOrdersImportRequest.InternalRecursiveSave();
}


public RC_2407b5abb2cbfeaeaa8da6cdea4ccf12 Duplicate() {
RC_2407b5abb2cbfeaeaa8da6cdea4ccf12 t;
t.ssENOrdersImportRequest = (EN_8c3668a93870461b8ea1216c2848f298EntityRecord)this.ssENOrdersImportRequest.Duplicate();
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
if (head == "ordersimportrequest") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrdersImportRequest")) variable.Value = ssENOrdersImportRequest; else variable.Optimized = true;
variable.SetFieldName("ordersimportrequest");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENOrdersImportRequest.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENOrdersImportRequest.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdOrdersImportRequest) {
return ssENOrdersImportRequest;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdOrdersImportRequest.Key.AsGuid) {
return ssENOrdersImportRequest;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENOrdersImportRequest.FillFromOther((IRecord) other.AttributeGet(IdOrdersImportRequest));
}
} // RC_2407b5abb2cbfeaeaa8da6cdea4ccf12
/// <summary>
/// RecordList type <code>OrdersImportRequestRecordList</code> that represents a record list of
///  <code>OrdersImportRequest</code>
/// </summary>
public partial class RL_40391f6554740b0683ce6790af83e1c0 : GenericRecordList<RC_2407b5abb2cbfeaeaa8da6cdea4ccf12>, IEnumerable, IEnumerator {

protected override RC_2407b5abb2cbfeaeaa8da6cdea4ccf12 GetElementDefaultValue() {
return new RC_2407b5abb2cbfeaeaa8da6cdea4ccf12();
}

public T[] ToArray<T>(Func<RC_2407b5abb2cbfeaeaa8da6cdea4ccf12, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_40391f6554740b0683ce6790af83e1c0 recordList, Func<RC_2407b5abb2cbfeaeaa8da6cdea4ccf12, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_40391f6554740b0683ce6790af83e1c0(RC_2407b5abb2cbfeaeaa8da6cdea4ccf12[] array) {
  RL_40391f6554740b0683ce6790af83e1c0 result = new RL_40391f6554740b0683ce6790af83e1c0();
result.InnerFromArray(array);
    return result;
}

public static RL_40391f6554740b0683ce6790af83e1c0 ToList<T>(T[] array, Func <T, RC_2407b5abb2cbfeaeaa8da6cdea4ccf12> converter) {
  RL_40391f6554740b0683ce6790af83e1c0 result = new RL_40391f6554740b0683ce6790af83e1c0();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_40391f6554740b0683ce6790af83e1c0 FromRestList<T>(RestList<T> restList, Func <T, RC_2407b5abb2cbfeaeaa8da6cdea4ccf12> converter) {
  RL_40391f6554740b0683ce6790af83e1c0 result = new RL_40391f6554740b0683ce6790af83e1c0();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_40391f6554740b0683ce6790af83e1c0() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(10,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_2407b5abb2cbfeaeaa8da6cdea4ccf12> NewList() {
return new RL_40391f6554740b0683ce6790af83e1c0();
}


} // RL_40391f6554740b0683ce6790af83e1c0
}

