namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (c2bKdybm40i1u3KbozbO+w)
///  <code>RC_33e6e9ec201f65e0eb7bd5d251178def</code> that represents <code>SupplierUserRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: SupplierUserRecord
public partial struct RC_33e6e9ec201f65e0eb7bd5d251178def : ITypedRecord<RC_33e6e9ec201f65e0eb7bd5d251178def> {
internal static readonly GlobalObjectKey IdSupplierUser = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*7OnmMx8g4GXre9XSUReN7w");

public EN_360367a38fba8439556dd1e5826e0428EntityRecord ssENSupplierUser;


public static implicit operator EN_360367a38fba8439556dd1e5826e0428EntityRecord( RC_33e6e9ec201f65e0eb7bd5d251178def r) {
return r.ssENSupplierUser;
}

public static implicit operator RC_33e6e9ec201f65e0eb7bd5d251178def (EN_360367a38fba8439556dd1e5826e0428EntityRecord r) {
RC_33e6e9ec201f65e0eb7bd5d251178def res = new RC_33e6e9ec201f65e0eb7bd5d251178def ();
res.ssENSupplierUser = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENSupplierUser.ChangedAttributes = value;
}
get {
    return ssENSupplierUser.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_33e6e9ec201f65e0eb7bd5d251178def() {
OptimizedAttributes = null;
ssENSupplierUser = new EN_360367a38fba8439556dd1e5826e0428EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(15,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENSupplierUser.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENSupplierUser.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENSupplierUser.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENSupplierUser.Read( r, ref index);
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
public void ReadIM(RC_33e6e9ec201f65e0eb7bd5d251178def r) {
this = r;
}


public static bool operator == (RC_33e6e9ec201f65e0eb7bd5d251178def a, RC_33e6e9ec201f65e0eb7bd5d251178def b) {
if (a.ssENSupplierUser != b.ssENSupplierUser) return false;
return true;
}

public static bool operator != (RC_33e6e9ec201f65e0eb7bd5d251178def a, RC_33e6e9ec201f65e0eb7bd5d251178def b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_33e6e9ec201f65e0eb7bd5d251178def)) return false;
return (this == (RC_33e6e9ec201f65e0eb7bd5d251178def)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENSupplierUser.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENSupplierUser.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENSupplierUser.InternalRecursiveSave();
}


public RC_33e6e9ec201f65e0eb7bd5d251178def Duplicate() {
RC_33e6e9ec201f65e0eb7bd5d251178def t;
t.ssENSupplierUser = (EN_360367a38fba8439556dd1e5826e0428EntityRecord)this.ssENSupplierUser.Duplicate();
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
if (head == "supplieruser") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SupplierUser")) variable.Value = ssENSupplierUser; else variable.Optimized = true;
variable.SetFieldName("supplieruser");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENSupplierUser.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENSupplierUser.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdSupplierUser) {
return ssENSupplierUser;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdSupplierUser.Key.AsGuid) {
return ssENSupplierUser;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENSupplierUser.FillFromOther((IRecord) other.AttributeGet(IdSupplierUser));
}
} // RC_33e6e9ec201f65e0eb7bd5d251178def
/// <summary>
/// RecordList type <code>SupplierUserRecordList</code> that represents a record list of
///  <code>SupplierUser</code>
/// </summary>
public partial class RL_84bdfe424d1eb0223fc2b8cfa9bb96be : GenericRecordList<RC_33e6e9ec201f65e0eb7bd5d251178def>, IEnumerable, IEnumerator {

protected override RC_33e6e9ec201f65e0eb7bd5d251178def GetElementDefaultValue() {
return new RC_33e6e9ec201f65e0eb7bd5d251178def();
}

public T[] ToArray<T>(Func<RC_33e6e9ec201f65e0eb7bd5d251178def, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_84bdfe424d1eb0223fc2b8cfa9bb96be recordList, Func<RC_33e6e9ec201f65e0eb7bd5d251178def, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_84bdfe424d1eb0223fc2b8cfa9bb96be(RC_33e6e9ec201f65e0eb7bd5d251178def[] array) {
  RL_84bdfe424d1eb0223fc2b8cfa9bb96be result = new RL_84bdfe424d1eb0223fc2b8cfa9bb96be();
result.InnerFromArray(array);
    return result;
}

public static RL_84bdfe424d1eb0223fc2b8cfa9bb96be ToList<T>(T[] array, Func <T, RC_33e6e9ec201f65e0eb7bd5d251178def> converter) {
  RL_84bdfe424d1eb0223fc2b8cfa9bb96be result = new RL_84bdfe424d1eb0223fc2b8cfa9bb96be();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_84bdfe424d1eb0223fc2b8cfa9bb96be FromRestList<T>(RestList<T> restList, Func <T, RC_33e6e9ec201f65e0eb7bd5d251178def> converter) {
  RL_84bdfe424d1eb0223fc2b8cfa9bb96be result = new RL_84bdfe424d1eb0223fc2b8cfa9bb96be();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_84bdfe424d1eb0223fc2b8cfa9bb96be() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(15,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_33e6e9ec201f65e0eb7bd5d251178def> NewList() {
return new RL_84bdfe424d1eb0223fc2b8cfa9bb96be();
}


} // RL_84bdfe424d1eb0223fc2b8cfa9bb96be
}

