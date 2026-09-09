namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (Ej5CBHlhZESHZxhNw0Mzfw)
///  <code>RC_3ae851ff8b62d3b4ff8041de781ce47d</code> that represents <code>EntraRoleRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: EntraRoleRecord
public partial struct RC_3ae851ff8b62d3b4ff8041de781ce47d : ITypedRecord<RC_3ae851ff8b62d3b4ff8041de781ce47d> {
internal static readonly GlobalObjectKey IdEntraRole = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*_1HoOmKLtNP_gEHeeBzkfQ");

public EN_d27d6d10f66f82966903ca7fd33164f8EntityRecord ssENEntraRole;


public static implicit operator EN_d27d6d10f66f82966903ca7fd33164f8EntityRecord( RC_3ae851ff8b62d3b4ff8041de781ce47d r) {
return r.ssENEntraRole;
}

public static implicit operator RC_3ae851ff8b62d3b4ff8041de781ce47d (EN_d27d6d10f66f82966903ca7fd33164f8EntityRecord r) {
RC_3ae851ff8b62d3b4ff8041de781ce47d res = new RC_3ae851ff8b62d3b4ff8041de781ce47d ();
res.ssENEntraRole = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENEntraRole.ChangedAttributes = value;
}
get {
    return ssENEntraRole.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_3ae851ff8b62d3b4ff8041de781ce47d() {
OptimizedAttributes = null;
ssENEntraRole = new EN_d27d6d10f66f82966903ca7fd33164f8EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(6,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENEntraRole.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENEntraRole.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENEntraRole.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENEntraRole.Read( r, ref index);
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
public void ReadIM(RC_3ae851ff8b62d3b4ff8041de781ce47d r) {
this = r;
}


public static bool operator == (RC_3ae851ff8b62d3b4ff8041de781ce47d a, RC_3ae851ff8b62d3b4ff8041de781ce47d b) {
if (a.ssENEntraRole != b.ssENEntraRole) return false;
return true;
}

public static bool operator != (RC_3ae851ff8b62d3b4ff8041de781ce47d a, RC_3ae851ff8b62d3b4ff8041de781ce47d b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_3ae851ff8b62d3b4ff8041de781ce47d)) return false;
return (this == (RC_3ae851ff8b62d3b4ff8041de781ce47d)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENEntraRole.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENEntraRole.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENEntraRole.InternalRecursiveSave();
}


public RC_3ae851ff8b62d3b4ff8041de781ce47d Duplicate() {
RC_3ae851ff8b62d3b4ff8041de781ce47d t;
t.ssENEntraRole = (EN_d27d6d10f66f82966903ca7fd33164f8EntityRecord)this.ssENEntraRole.Duplicate();
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
if (head == "entrarole") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".EntraRole")) variable.Value = ssENEntraRole; else variable.Optimized = true;
variable.SetFieldName("entrarole");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENEntraRole.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENEntraRole.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdEntraRole) {
return ssENEntraRole;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdEntraRole.Key.AsGuid) {
return ssENEntraRole;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENEntraRole.FillFromOther((IRecord) other.AttributeGet(IdEntraRole));
}
} // RC_3ae851ff8b62d3b4ff8041de781ce47d
/// <summary>
/// RecordList type <code>EntraRoleRecordList</code> that represents a record list of
///  <code>EntraRole</code>
/// </summary>
public partial class RL_084ec93001d810170970c8007b50b58f : GenericRecordList<RC_3ae851ff8b62d3b4ff8041de781ce47d>, IEnumerable, IEnumerator {

protected override RC_3ae851ff8b62d3b4ff8041de781ce47d GetElementDefaultValue() {
return new RC_3ae851ff8b62d3b4ff8041de781ce47d();
}

public T[] ToArray<T>(Func<RC_3ae851ff8b62d3b4ff8041de781ce47d, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_084ec93001d810170970c8007b50b58f recordList, Func<RC_3ae851ff8b62d3b4ff8041de781ce47d, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_084ec93001d810170970c8007b50b58f(RC_3ae851ff8b62d3b4ff8041de781ce47d[] array) {
  RL_084ec93001d810170970c8007b50b58f result = new RL_084ec93001d810170970c8007b50b58f();
result.InnerFromArray(array);
    return result;
}

public static RL_084ec93001d810170970c8007b50b58f ToList<T>(T[] array, Func <T, RC_3ae851ff8b62d3b4ff8041de781ce47d> converter) {
  RL_084ec93001d810170970c8007b50b58f result = new RL_084ec93001d810170970c8007b50b58f();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_084ec93001d810170970c8007b50b58f FromRestList<T>(RestList<T> restList, Func <T, RC_3ae851ff8b62d3b4ff8041de781ce47d> converter) {
  RL_084ec93001d810170970c8007b50b58f result = new RL_084ec93001d810170970c8007b50b58f();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_084ec93001d810170970c8007b50b58f() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(6,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_3ae851ff8b62d3b4ff8041de781ce47d> NewList() {
return new RL_084ec93001d810170970c8007b50b58f();
}


} // RL_084ec93001d810170970c8007b50b58f
}

