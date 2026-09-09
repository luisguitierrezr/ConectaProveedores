namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (wne4taoRska3Sn9nV8P+dw)
///  <code>RC_786a35d6d77ea6f67817eb0f3988b828</code> that represents <code>PurchasingGroupRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: PurchasingGroupRecord
public partial struct RC_786a35d6d77ea6f67817eb0f3988b828 : ITypedRecord<RC_786a35d6d77ea6f67817eb0f3988b828> {
internal static readonly GlobalObjectKey IdPurchasingGroup = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*1jVqeH7X9qZ4F+sPOYi4KA");

public EN_ee7b70c961cd5373a4bb51187762126fEntityRecord ssENPurchasingGroup;


public static implicit operator EN_ee7b70c961cd5373a4bb51187762126fEntityRecord( RC_786a35d6d77ea6f67817eb0f3988b828 r) {
return r.ssENPurchasingGroup;
}

public static implicit operator RC_786a35d6d77ea6f67817eb0f3988b828 (EN_ee7b70c961cd5373a4bb51187762126fEntityRecord r) {
RC_786a35d6d77ea6f67817eb0f3988b828 res = new RC_786a35d6d77ea6f67817eb0f3988b828 ();
res.ssENPurchasingGroup = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENPurchasingGroup.ChangedAttributes = value;
}
get {
    return ssENPurchasingGroup.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_786a35d6d77ea6f67817eb0f3988b828() {
OptimizedAttributes = null;
ssENPurchasingGroup = new EN_ee7b70c961cd5373a4bb51187762126fEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(11,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENPurchasingGroup.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENPurchasingGroup.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENPurchasingGroup.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENPurchasingGroup.Read( r, ref index);
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
public void ReadIM(RC_786a35d6d77ea6f67817eb0f3988b828 r) {
this = r;
}


public static bool operator == (RC_786a35d6d77ea6f67817eb0f3988b828 a, RC_786a35d6d77ea6f67817eb0f3988b828 b) {
if (a.ssENPurchasingGroup != b.ssENPurchasingGroup) return false;
return true;
}

public static bool operator != (RC_786a35d6d77ea6f67817eb0f3988b828 a, RC_786a35d6d77ea6f67817eb0f3988b828 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_786a35d6d77ea6f67817eb0f3988b828)) return false;
return (this == (RC_786a35d6d77ea6f67817eb0f3988b828)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENPurchasingGroup.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENPurchasingGroup.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENPurchasingGroup.InternalRecursiveSave();
}


public RC_786a35d6d77ea6f67817eb0f3988b828 Duplicate() {
RC_786a35d6d77ea6f67817eb0f3988b828 t;
t.ssENPurchasingGroup = (EN_ee7b70c961cd5373a4bb51187762126fEntityRecord)this.ssENPurchasingGroup.Duplicate();
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
if (head == "purchasinggroup") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PurchasingGroup")) variable.Value = ssENPurchasingGroup; else variable.Optimized = true;
variable.SetFieldName("purchasinggroup");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENPurchasingGroup.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENPurchasingGroup.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdPurchasingGroup) {
return ssENPurchasingGroup;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdPurchasingGroup.Key.AsGuid) {
return ssENPurchasingGroup;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENPurchasingGroup.FillFromOther((IRecord) other.AttributeGet(IdPurchasingGroup));
}
} // RC_786a35d6d77ea6f67817eb0f3988b828
/// <summary>
/// RecordList type <code>PurchasingGroupRecordList</code> that represents a record list of
///  <code>PurchasingGroup</code>
/// </summary>
public partial class RL_2f1913ca5a1161b385320626f9c00169 : GenericRecordList<RC_786a35d6d77ea6f67817eb0f3988b828>, IEnumerable, IEnumerator {

protected override RC_786a35d6d77ea6f67817eb0f3988b828 GetElementDefaultValue() {
return new RC_786a35d6d77ea6f67817eb0f3988b828();
}

public T[] ToArray<T>(Func<RC_786a35d6d77ea6f67817eb0f3988b828, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_2f1913ca5a1161b385320626f9c00169 recordList, Func<RC_786a35d6d77ea6f67817eb0f3988b828, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_2f1913ca5a1161b385320626f9c00169(RC_786a35d6d77ea6f67817eb0f3988b828[] array) {
  RL_2f1913ca5a1161b385320626f9c00169 result = new RL_2f1913ca5a1161b385320626f9c00169();
result.InnerFromArray(array);
    return result;
}

public static RL_2f1913ca5a1161b385320626f9c00169 ToList<T>(T[] array, Func <T, RC_786a35d6d77ea6f67817eb0f3988b828> converter) {
  RL_2f1913ca5a1161b385320626f9c00169 result = new RL_2f1913ca5a1161b385320626f9c00169();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_2f1913ca5a1161b385320626f9c00169 FromRestList<T>(RestList<T> restList, Func <T, RC_786a35d6d77ea6f67817eb0f3988b828> converter) {
  RL_2f1913ca5a1161b385320626f9c00169 result = new RL_2f1913ca5a1161b385320626f9c00169();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_2f1913ca5a1161b385320626f9c00169() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(11,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_786a35d6d77ea6f67817eb0f3988b828> NewList() {
return new RL_2f1913ca5a1161b385320626f9c00169();
}


} // RL_2f1913ca5a1161b385320626f9c00169
}

