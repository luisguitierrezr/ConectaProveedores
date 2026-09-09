namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (lUwCJ2b4T0yYUdIl+U_vkA)
///  <code>RC_e733222bc824981c762ab14c37fad18d</code> that represents <code>TotalRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: TotalRecord
public partial struct RC_e733222bc824981c762ab14c37fad18d : ITypedRecord<RC_e733222bc824981c762ab14c37fad18d> {
internal static readonly GlobalObjectKey IdTotal = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*KyIz5yTIHJh2KrFMN_rRjQ");

public ST_18874ac0b41f9a239dad794ccac4f8d3Structure ssSTTotal;


public static implicit operator ST_18874ac0b41f9a239dad794ccac4f8d3Structure( RC_e733222bc824981c762ab14c37fad18d r) {
return r.ssSTTotal;
}

public static implicit operator RC_e733222bc824981c762ab14c37fad18d (ST_18874ac0b41f9a239dad794ccac4f8d3Structure r) {
RC_e733222bc824981c762ab14c37fad18d res = new RC_e733222bc824981c762ab14c37fad18d ();
res.ssSTTotal = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_e733222bc824981c762ab14c37fad18d() {
OptimizedAttributes = null;
ssSTTotal = new ST_18874ac0b41f9a239dad794ccac4f8d3Structure();
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
    ssSTTotal.OptimizedAttributes = value[0];
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
ssSTTotal.Read( r, ref index);
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
public void ReadIM(RC_e733222bc824981c762ab14c37fad18d r) {
this = r;
}


public static bool operator == (RC_e733222bc824981c762ab14c37fad18d a, RC_e733222bc824981c762ab14c37fad18d b) {
if (a.ssSTTotal != b.ssSTTotal) return false;
return true;
}

public static bool operator != (RC_e733222bc824981c762ab14c37fad18d a, RC_e733222bc824981c762ab14c37fad18d b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_e733222bc824981c762ab14c37fad18d)) return false;
return (this == (RC_e733222bc824981c762ab14c37fad18d)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTTotal.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTTotal.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTTotal.InternalRecursiveSave();
}


public RC_e733222bc824981c762ab14c37fad18d Duplicate() {
RC_e733222bc824981c762ab14c37fad18d t;
t.ssSTTotal = (ST_18874ac0b41f9a239dad794ccac4f8d3Structure)this.ssSTTotal.Duplicate();
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
if (head == "total") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Total")) variable.Value = ssSTTotal; else variable.Optimized = true;
variable.SetFieldName("total");
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
if (key == IdTotal) {
return ssSTTotal;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdTotal.Key.AsGuid) {
return ssSTTotal;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTTotal.FillFromOther((IRecord) other.AttributeGet(IdTotal));
}
} // RC_e733222bc824981c762ab14c37fad18d
/// <summary>
/// RecordList type <code>TotalRecordList</code> that represents a record list of <code>Decimal</code>
/// </summary>
public partial class RL_516b8a2b0fa040ead03115e8bb85ea9b : GenericRecordList<RC_e733222bc824981c762ab14c37fad18d>, IEnumerable, IEnumerator {

protected override RC_e733222bc824981c762ab14c37fad18d GetElementDefaultValue() {
return new RC_e733222bc824981c762ab14c37fad18d();
}

public T[] ToArray<T>(Func<RC_e733222bc824981c762ab14c37fad18d, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_516b8a2b0fa040ead03115e8bb85ea9b recordList, Func<RC_e733222bc824981c762ab14c37fad18d, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_516b8a2b0fa040ead03115e8bb85ea9b(RC_e733222bc824981c762ab14c37fad18d[] array) {
  RL_516b8a2b0fa040ead03115e8bb85ea9b result = new RL_516b8a2b0fa040ead03115e8bb85ea9b();
result.InnerFromArray(array);
    return result;
}

public static RL_516b8a2b0fa040ead03115e8bb85ea9b ToList<T>(T[] array, Func <T, RC_e733222bc824981c762ab14c37fad18d> converter) {
  RL_516b8a2b0fa040ead03115e8bb85ea9b result = new RL_516b8a2b0fa040ead03115e8bb85ea9b();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_516b8a2b0fa040ead03115e8bb85ea9b FromRestList<T>(RestList<T> restList, Func <T, RC_e733222bc824981c762ab14c37fad18d> converter) {
  RL_516b8a2b0fa040ead03115e8bb85ea9b result = new RL_516b8a2b0fa040ead03115e8bb85ea9b();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_516b8a2b0fa040ead03115e8bb85ea9b() : base() {
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
protected override OSList<RC_e733222bc824981c762ab14c37fad18d> NewList() {
return new RL_516b8a2b0fa040ead03115e8bb85ea9b();
}


} // RL_516b8a2b0fa040ead03115e8bb85ea9b
}

