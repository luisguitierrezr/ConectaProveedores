namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (3dXCmZDWMk+DIERGnCMBNg)
///  <code>RC_66f7e325389c77502effc220cef9c6fe</code> that represents <code>dataoutput2Record</code
/// > <p>Description: </p>
/// </summary>
// Name: dataoutput2Record
public partial struct RC_66f7e325389c77502effc220cef9c6fe : ITypedRecord<RC_66f7e325389c77502effc220cef9c6fe> {
internal static readonly GlobalObjectKey Iddataoutput2 = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*JeP3Zpw4UHcu_8IgzvnG_g");

public ST_91300ad987a75a51816ab4149ce29870Structure ssSTdataoutput2;


public static implicit operator ST_91300ad987a75a51816ab4149ce29870Structure( RC_66f7e325389c77502effc220cef9c6fe r) {
return r.ssSTdataoutput2;
}

public static implicit operator RC_66f7e325389c77502effc220cef9c6fe (ST_91300ad987a75a51816ab4149ce29870Structure r) {
RC_66f7e325389c77502effc220cef9c6fe res = new RC_66f7e325389c77502effc220cef9c6fe ();
res.ssSTdataoutput2 = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_66f7e325389c77502effc220cef9c6fe() {
OptimizedAttributes = null;
ssSTdataoutput2 = new ST_91300ad987a75a51816ab4149ce29870Structure();
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
    ssSTdataoutput2.OptimizedAttributes = value[0];
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
ssSTdataoutput2.Read( r, ref index);
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
public void ReadIM(RC_66f7e325389c77502effc220cef9c6fe r) {
this = r;
}


public static bool operator == (RC_66f7e325389c77502effc220cef9c6fe a, RC_66f7e325389c77502effc220cef9c6fe b) {
if (a.ssSTdataoutput2 != b.ssSTdataoutput2) return false;
return true;
}

public static bool operator != (RC_66f7e325389c77502effc220cef9c6fe a, RC_66f7e325389c77502effc220cef9c6fe b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_66f7e325389c77502effc220cef9c6fe)) return false;
return (this == (RC_66f7e325389c77502effc220cef9c6fe)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTdataoutput2.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTdataoutput2.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTdataoutput2.InternalRecursiveSave();
}


public RC_66f7e325389c77502effc220cef9c6fe Duplicate() {
RC_66f7e325389c77502effc220cef9c6fe t;
t.ssSTdataoutput2 = (ST_91300ad987a75a51816ab4149ce29870Structure)this.ssSTdataoutput2.Duplicate();
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
if (head == "dataoutput2") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".dataoutput2")) variable.Value = ssSTdataoutput2; else variable.Optimized = true;
variable.SetFieldName("dataoutput2");
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
if (key == Iddataoutput2) {
return ssSTdataoutput2;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == Iddataoutput2.Key.AsGuid) {
return ssSTdataoutput2;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTdataoutput2.FillFromOther((IRecord) other.AttributeGet(Iddataoutput2));
}
} // RC_66f7e325389c77502effc220cef9c6fe
/// <summary>
/// RecordList type <code>dataoutput2RecordList</code> that represents a record list of
///  <code>dataoutput2</code>
/// </summary>
public partial class RL_8db89dbc91426a304050c0fae33e8cd3 : GenericRecordList<RC_66f7e325389c77502effc220cef9c6fe>, IEnumerable, IEnumerator {

protected override RC_66f7e325389c77502effc220cef9c6fe GetElementDefaultValue() {
return new RC_66f7e325389c77502effc220cef9c6fe();
}

public T[] ToArray<T>(Func<RC_66f7e325389c77502effc220cef9c6fe, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_8db89dbc91426a304050c0fae33e8cd3 recordList, Func<RC_66f7e325389c77502effc220cef9c6fe, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_8db89dbc91426a304050c0fae33e8cd3(RC_66f7e325389c77502effc220cef9c6fe[] array) {
  RL_8db89dbc91426a304050c0fae33e8cd3 result = new RL_8db89dbc91426a304050c0fae33e8cd3();
result.InnerFromArray(array);
    return result;
}

public static RL_8db89dbc91426a304050c0fae33e8cd3 ToList<T>(T[] array, Func <T, RC_66f7e325389c77502effc220cef9c6fe> converter) {
  RL_8db89dbc91426a304050c0fae33e8cd3 result = new RL_8db89dbc91426a304050c0fae33e8cd3();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_8db89dbc91426a304050c0fae33e8cd3 FromRestList<T>(RestList<T> restList, Func <T, RC_66f7e325389c77502effc220cef9c6fe> converter) {
  RL_8db89dbc91426a304050c0fae33e8cd3 result = new RL_8db89dbc91426a304050c0fae33e8cd3();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_8db89dbc91426a304050c0fae33e8cd3() : base() {
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
protected override OSList<RC_66f7e325389c77502effc220cef9c6fe> NewList() {
return new RL_8db89dbc91426a304050c0fae33e8cd3();
}


} // RL_8db89dbc91426a304050c0fae33e8cd3
}

