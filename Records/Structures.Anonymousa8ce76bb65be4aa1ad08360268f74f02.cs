namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (u3bOqL5loUqtCDYCaPdPAg)
///  <code>RC_549f08e709528a6bf28106addf9f0382</code> that represents <code>VirtualStoreRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: VirtualStoreRecord
public partial struct RC_549f08e709528a6bf28106addf9f0382 : ITypedRecord<RC_549f08e709528a6bf28106addf9f0382> {
internal static readonly GlobalObjectKey IdVirtualStore = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*5wifVFIJa4rygQat358Dgg");

public EN_7880828d2b18947e22126c6c81b5d72dEntityRecord ssENVirtualStore;


public static implicit operator EN_7880828d2b18947e22126c6c81b5d72dEntityRecord( RC_549f08e709528a6bf28106addf9f0382 r) {
return r.ssENVirtualStore;
}

public static implicit operator RC_549f08e709528a6bf28106addf9f0382 (EN_7880828d2b18947e22126c6c81b5d72dEntityRecord r) {
RC_549f08e709528a6bf28106addf9f0382 res = new RC_549f08e709528a6bf28106addf9f0382 ();
res.ssENVirtualStore = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENVirtualStore.ChangedAttributes = value;
}
get {
    return ssENVirtualStore.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_549f08e709528a6bf28106addf9f0382() {
OptimizedAttributes = null;
ssENVirtualStore = new EN_7880828d2b18947e22126c6c81b5d72dEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(3,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENVirtualStore.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENVirtualStore.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENVirtualStore.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENVirtualStore.Read( r, ref index);
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
public void ReadIM(RC_549f08e709528a6bf28106addf9f0382 r) {
this = r;
}


public static bool operator == (RC_549f08e709528a6bf28106addf9f0382 a, RC_549f08e709528a6bf28106addf9f0382 b) {
if (a.ssENVirtualStore != b.ssENVirtualStore) return false;
return true;
}

public static bool operator != (RC_549f08e709528a6bf28106addf9f0382 a, RC_549f08e709528a6bf28106addf9f0382 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_549f08e709528a6bf28106addf9f0382)) return false;
return (this == (RC_549f08e709528a6bf28106addf9f0382)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENVirtualStore.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENVirtualStore.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENVirtualStore.InternalRecursiveSave();
}


public RC_549f08e709528a6bf28106addf9f0382 Duplicate() {
RC_549f08e709528a6bf28106addf9f0382 t;
t.ssENVirtualStore = (EN_7880828d2b18947e22126c6c81b5d72dEntityRecord)this.ssENVirtualStore.Duplicate();
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
if (head == "virtualstore") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".VirtualStore")) variable.Value = ssENVirtualStore; else variable.Optimized = true;
variable.SetFieldName("virtualstore");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENVirtualStore.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENVirtualStore.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdVirtualStore) {
return ssENVirtualStore;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdVirtualStore.Key.AsGuid) {
return ssENVirtualStore;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENVirtualStore.FillFromOther((IRecord) other.AttributeGet(IdVirtualStore));
}
} // RC_549f08e709528a6bf28106addf9f0382
/// <summary>
/// RecordList type <code>VirtualStoreRecordList</code> that represents a record list of
///  <code>VirtualStore</code>
/// </summary>
public partial class RL_f6ff3859377cc9c3ed97710b330e3b95 : GenericRecordList<RC_549f08e709528a6bf28106addf9f0382>, IEnumerable, IEnumerator {

protected override RC_549f08e709528a6bf28106addf9f0382 GetElementDefaultValue() {
return new RC_549f08e709528a6bf28106addf9f0382();
}

public T[] ToArray<T>(Func<RC_549f08e709528a6bf28106addf9f0382, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_f6ff3859377cc9c3ed97710b330e3b95 recordList, Func<RC_549f08e709528a6bf28106addf9f0382, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_f6ff3859377cc9c3ed97710b330e3b95(RC_549f08e709528a6bf28106addf9f0382[] array) {
  RL_f6ff3859377cc9c3ed97710b330e3b95 result = new RL_f6ff3859377cc9c3ed97710b330e3b95();
result.InnerFromArray(array);
    return result;
}

public static RL_f6ff3859377cc9c3ed97710b330e3b95 ToList<T>(T[] array, Func <T, RC_549f08e709528a6bf28106addf9f0382> converter) {
  RL_f6ff3859377cc9c3ed97710b330e3b95 result = new RL_f6ff3859377cc9c3ed97710b330e3b95();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_f6ff3859377cc9c3ed97710b330e3b95 FromRestList<T>(RestList<T> restList, Func <T, RC_549f08e709528a6bf28106addf9f0382> converter) {
  RL_f6ff3859377cc9c3ed97710b330e3b95 result = new RL_f6ff3859377cc9c3ed97710b330e3b95();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_f6ff3859377cc9c3ed97710b330e3b95() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(3,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_549f08e709528a6bf28106addf9f0382> NewList() {
return new RL_f6ff3859377cc9c3ed97710b330e3b95();
}


} // RL_f6ff3859377cc9c3ed97710b330e3b95
}

