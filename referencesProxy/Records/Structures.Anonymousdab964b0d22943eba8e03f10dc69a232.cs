namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (sGS52inS60Oo4D8Q3GmiMg)
///  <code>RC_1789507e695396bb66757dd83a78c4b5</code> that represents <code>DeletedStorageRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: DeletedStorageRecord
public partial struct RC_1789507e695396bb66757dd83a78c4b5 : ITypedRecord<RC_1789507e695396bb66757dd83a78c4b5> {
internal static readonly GlobalObjectKey IdDeletedStorage = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*flCJF1Npu5ZmdX3YOnjEtQ");

public EN_cddda4c1238a2c23ce999ed0bb374320EntityRecord ssENDeletedStorage;


public static implicit operator EN_cddda4c1238a2c23ce999ed0bb374320EntityRecord( RC_1789507e695396bb66757dd83a78c4b5 r) {
return r.ssENDeletedStorage;
}

public static implicit operator RC_1789507e695396bb66757dd83a78c4b5 (EN_cddda4c1238a2c23ce999ed0bb374320EntityRecord r) {
RC_1789507e695396bb66757dd83a78c4b5 res = new RC_1789507e695396bb66757dd83a78c4b5 ();
res.ssENDeletedStorage = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENDeletedStorage.ChangedAttributes = value;
}
get {
    return ssENDeletedStorage.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_1789507e695396bb66757dd83a78c4b5() {
OptimizedAttributes = null;
ssENDeletedStorage = new EN_cddda4c1238a2c23ce999ed0bb374320EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(9,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENDeletedStorage.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENDeletedStorage.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENDeletedStorage.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENDeletedStorage.Read( r, ref index);
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
public void ReadIM(RC_1789507e695396bb66757dd83a78c4b5 r) {
this = r;
}


public static bool operator == (RC_1789507e695396bb66757dd83a78c4b5 a, RC_1789507e695396bb66757dd83a78c4b5 b) {
if (a.ssENDeletedStorage != b.ssENDeletedStorage) return false;
return true;
}

public static bool operator != (RC_1789507e695396bb66757dd83a78c4b5 a, RC_1789507e695396bb66757dd83a78c4b5 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_1789507e695396bb66757dd83a78c4b5)) return false;
return (this == (RC_1789507e695396bb66757dd83a78c4b5)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENDeletedStorage.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENDeletedStorage.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENDeletedStorage.InternalRecursiveSave();
}


public RC_1789507e695396bb66757dd83a78c4b5 Duplicate() {
RC_1789507e695396bb66757dd83a78c4b5 t;
t.ssENDeletedStorage = (EN_cddda4c1238a2c23ce999ed0bb374320EntityRecord)this.ssENDeletedStorage.Duplicate();
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
if (head == "deletedstorage") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".DeletedStorage")) variable.Value = ssENDeletedStorage; else variable.Optimized = true;
variable.SetFieldName("deletedstorage");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENDeletedStorage.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENDeletedStorage.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdDeletedStorage) {
return ssENDeletedStorage;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdDeletedStorage.Key.AsGuid) {
return ssENDeletedStorage;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENDeletedStorage.FillFromOther((IRecord) other.AttributeGet(IdDeletedStorage));
}
} // RC_1789507e695396bb66757dd83a78c4b5
/// <summary>
/// RecordList type <code>DeletedStorageRecordList</code> that represents a record list of
///  <code>DeletedStorage</code>
/// </summary>
public partial class RL_860298826198654ea08dbde054bb1413 : GenericRecordList<RC_1789507e695396bb66757dd83a78c4b5>, IEnumerable, IEnumerator {

protected override RC_1789507e695396bb66757dd83a78c4b5 GetElementDefaultValue() {
return new RC_1789507e695396bb66757dd83a78c4b5();
}

public T[] ToArray<T>(Func<RC_1789507e695396bb66757dd83a78c4b5, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_860298826198654ea08dbde054bb1413 recordList, Func<RC_1789507e695396bb66757dd83a78c4b5, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_860298826198654ea08dbde054bb1413(RC_1789507e695396bb66757dd83a78c4b5[] array) {
  RL_860298826198654ea08dbde054bb1413 result = new RL_860298826198654ea08dbde054bb1413();
result.InnerFromArray(array);
    return result;
}

public static RL_860298826198654ea08dbde054bb1413 ToList<T>(T[] array, Func <T, RC_1789507e695396bb66757dd83a78c4b5> converter) {
  RL_860298826198654ea08dbde054bb1413 result = new RL_860298826198654ea08dbde054bb1413();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_860298826198654ea08dbde054bb1413 FromRestList<T>(RestList<T> restList, Func <T, RC_1789507e695396bb66757dd83a78c4b5> converter) {
  RL_860298826198654ea08dbde054bb1413 result = new RL_860298826198654ea08dbde054bb1413();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_860298826198654ea08dbde054bb1413() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(9,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_1789507e695396bb66757dd83a78c4b5> NewList() {
return new RL_860298826198654ea08dbde054bb1413();
}


} // RL_860298826198654ea08dbde054bb1413
}

