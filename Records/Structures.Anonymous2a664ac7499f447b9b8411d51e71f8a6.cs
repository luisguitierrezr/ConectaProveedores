namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (x0pmKp9Je0SbhBHVHnH4pg)
///  <code>RC_a224d98ed725f0a01e029de10d28bcba</code> that represents <code>ValidRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: ValidRecord
public partial struct RC_a224d98ed725f0a01e029de10d28bcba : ITypedRecord<RC_a224d98ed725f0a01e029de10d28bcba> {
internal static readonly GlobalObjectKey IdValid = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*jtkkoiXXoPAeAp3hDSi8ug");

public ST_b453bea0930035904f55a74692afd3a8Structure ssSTValid;


public static implicit operator ST_b453bea0930035904f55a74692afd3a8Structure( RC_a224d98ed725f0a01e029de10d28bcba r) {
return r.ssSTValid;
}

public static implicit operator RC_a224d98ed725f0a01e029de10d28bcba (ST_b453bea0930035904f55a74692afd3a8Structure r) {
RC_a224d98ed725f0a01e029de10d28bcba res = new RC_a224d98ed725f0a01e029de10d28bcba ();
res.ssSTValid = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_a224d98ed725f0a01e029de10d28bcba() {
OptimizedAttributes = null;
ssSTValid = new ST_b453bea0930035904f55a74692afd3a8Structure();
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
    ssSTValid.OptimizedAttributes = value[0];
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
ssSTValid.Read( r, ref index);
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
public void ReadIM(RC_a224d98ed725f0a01e029de10d28bcba r) {
this = r;
}


public static bool operator == (RC_a224d98ed725f0a01e029de10d28bcba a, RC_a224d98ed725f0a01e029de10d28bcba b) {
if (a.ssSTValid != b.ssSTValid) return false;
return true;
}

public static bool operator != (RC_a224d98ed725f0a01e029de10d28bcba a, RC_a224d98ed725f0a01e029de10d28bcba b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_a224d98ed725f0a01e029de10d28bcba)) return false;
return (this == (RC_a224d98ed725f0a01e029de10d28bcba)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTValid.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTValid.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTValid.InternalRecursiveSave();
}


public RC_a224d98ed725f0a01e029de10d28bcba Duplicate() {
RC_a224d98ed725f0a01e029de10d28bcba t;
t.ssSTValid = (ST_b453bea0930035904f55a74692afd3a8Structure)this.ssSTValid.Duplicate();
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
if (head == "valid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Valid")) variable.Value = ssSTValid; else variable.Optimized = true;
variable.SetFieldName("valid");
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
if (key == IdValid) {
return ssSTValid;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdValid.Key.AsGuid) {
return ssSTValid;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTValid.FillFromOther((IRecord) other.AttributeGet(IdValid));
}
} // RC_a224d98ed725f0a01e029de10d28bcba
/// <summary>
/// RecordList type <code>ValidRecordList</code> that represents a record list of <code>Valid</code>
/// </summary>
public partial class RL_5dffcaa567afd279afde60e5a6b0b2ca : GenericRecordList<RC_a224d98ed725f0a01e029de10d28bcba>, IEnumerable, IEnumerator {

protected override RC_a224d98ed725f0a01e029de10d28bcba GetElementDefaultValue() {
return new RC_a224d98ed725f0a01e029de10d28bcba();
}

public T[] ToArray<T>(Func<RC_a224d98ed725f0a01e029de10d28bcba, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_5dffcaa567afd279afde60e5a6b0b2ca recordList, Func<RC_a224d98ed725f0a01e029de10d28bcba, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_5dffcaa567afd279afde60e5a6b0b2ca(RC_a224d98ed725f0a01e029de10d28bcba[] array) {
  RL_5dffcaa567afd279afde60e5a6b0b2ca result = new RL_5dffcaa567afd279afde60e5a6b0b2ca();
result.InnerFromArray(array);
    return result;
}

public static RL_5dffcaa567afd279afde60e5a6b0b2ca ToList<T>(T[] array, Func <T, RC_a224d98ed725f0a01e029de10d28bcba> converter) {
  RL_5dffcaa567afd279afde60e5a6b0b2ca result = new RL_5dffcaa567afd279afde60e5a6b0b2ca();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_5dffcaa567afd279afde60e5a6b0b2ca FromRestList<T>(RestList<T> restList, Func <T, RC_a224d98ed725f0a01e029de10d28bcba> converter) {
  RL_5dffcaa567afd279afde60e5a6b0b2ca result = new RL_5dffcaa567afd279afde60e5a6b0b2ca();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_5dffcaa567afd279afde60e5a6b0b2ca() : base() {
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
protected override OSList<RC_a224d98ed725f0a01e029de10d28bcba> NewList() {
return new RL_5dffcaa567afd279afde60e5a6b0b2ca();
}


} // RL_5dffcaa567afd279afde60e5a6b0b2ca
}

