namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (a8nGLQw_Q0qDJKBskDujZg)
///  <code>RC_a9c222d16d2a5710a4b4eb27d615bc5d</code> that represent
/// s <code>EmailNotifTesorariaRecord</code> <p>Description: </p>
/// </summary>
// Name: EmailNotifTesorariaRecord
public partial struct RC_a9c222d16d2a5710a4b4eb27d615bc5d : ITypedRecord<RC_a9c222d16d2a5710a4b4eb27d615bc5d> {
internal static readonly GlobalObjectKey IdEmailNotifTesoraria = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*0SLCqSptEFektOsn1hW8XQ");

public ST_b97a22be0cf9a9b2c6ab22fc6bcd3c6dStructure ssSTEmailNotifTesoraria;


public static implicit operator ST_b97a22be0cf9a9b2c6ab22fc6bcd3c6dStructure( RC_a9c222d16d2a5710a4b4eb27d615bc5d r) {
return r.ssSTEmailNotifTesoraria;
}

public static implicit operator RC_a9c222d16d2a5710a4b4eb27d615bc5d (ST_b97a22be0cf9a9b2c6ab22fc6bcd3c6dStructure r) {
RC_a9c222d16d2a5710a4b4eb27d615bc5d res = new RC_a9c222d16d2a5710a4b4eb27d615bc5d ();
res.ssSTEmailNotifTesoraria = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_a9c222d16d2a5710a4b4eb27d615bc5d() {
OptimizedAttributes = null;
ssSTEmailNotifTesoraria = new ST_b97a22be0cf9a9b2c6ab22fc6bcd3c6dStructure();
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
    ssSTEmailNotifTesoraria.OptimizedAttributes = value[0];
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
ssSTEmailNotifTesoraria.Read( r, ref index);
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
public void ReadIM(RC_a9c222d16d2a5710a4b4eb27d615bc5d r) {
this = r;
}


public static bool operator == (RC_a9c222d16d2a5710a4b4eb27d615bc5d a, RC_a9c222d16d2a5710a4b4eb27d615bc5d b) {
if (a.ssSTEmailNotifTesoraria != b.ssSTEmailNotifTesoraria) return false;
return true;
}

public static bool operator != (RC_a9c222d16d2a5710a4b4eb27d615bc5d a, RC_a9c222d16d2a5710a4b4eb27d615bc5d b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_a9c222d16d2a5710a4b4eb27d615bc5d)) return false;
return (this == (RC_a9c222d16d2a5710a4b4eb27d615bc5d)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTEmailNotifTesoraria.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTEmailNotifTesoraria.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTEmailNotifTesoraria.InternalRecursiveSave();
}


public RC_a9c222d16d2a5710a4b4eb27d615bc5d Duplicate() {
RC_a9c222d16d2a5710a4b4eb27d615bc5d t;
t.ssSTEmailNotifTesoraria = (ST_b97a22be0cf9a9b2c6ab22fc6bcd3c6dStructure)this.ssSTEmailNotifTesoraria.Duplicate();
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
if (head == "emailnotiftesoraria") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".EmailNotifTesoraria")) variable.Value = ssSTEmailNotifTesoraria; else variable.Optimized = true;
variable.SetFieldName("emailnotiftesoraria");
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
if (key == IdEmailNotifTesoraria) {
return ssSTEmailNotifTesoraria;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdEmailNotifTesoraria.Key.AsGuid) {
return ssSTEmailNotifTesoraria;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTEmailNotifTesoraria.FillFromOther((IRecord) other.AttributeGet(IdEmailNotifTesoraria));
}
} // RC_a9c222d16d2a5710a4b4eb27d615bc5d
/// <summary>
/// RecordList type <code>EmailNotifTesorariaRecordList</code> that represents a record list of
///  <code>EmailNotifTesoraria</code>
/// </summary>
public partial class RL_5c521606738167349ee06b331bd15dfd : GenericRecordList<RC_a9c222d16d2a5710a4b4eb27d615bc5d>, IEnumerable, IEnumerator {

protected override RC_a9c222d16d2a5710a4b4eb27d615bc5d GetElementDefaultValue() {
return new RC_a9c222d16d2a5710a4b4eb27d615bc5d();
}

public T[] ToArray<T>(Func<RC_a9c222d16d2a5710a4b4eb27d615bc5d, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_5c521606738167349ee06b331bd15dfd recordList, Func<RC_a9c222d16d2a5710a4b4eb27d615bc5d, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_5c521606738167349ee06b331bd15dfd(RC_a9c222d16d2a5710a4b4eb27d615bc5d[] array) {
  RL_5c521606738167349ee06b331bd15dfd result = new RL_5c521606738167349ee06b331bd15dfd();
result.InnerFromArray(array);
    return result;
}

public static RL_5c521606738167349ee06b331bd15dfd ToList<T>(T[] array, Func <T, RC_a9c222d16d2a5710a4b4eb27d615bc5d> converter) {
  RL_5c521606738167349ee06b331bd15dfd result = new RL_5c521606738167349ee06b331bd15dfd();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_5c521606738167349ee06b331bd15dfd FromRestList<T>(RestList<T> restList, Func <T, RC_a9c222d16d2a5710a4b4eb27d615bc5d> converter) {
  RL_5c521606738167349ee06b331bd15dfd result = new RL_5c521606738167349ee06b331bd15dfd();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_5c521606738167349ee06b331bd15dfd() : base() {
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
protected override OSList<RC_a9c222d16d2a5710a4b4eb27d615bc5d> NewList() {
return new RL_5c521606738167349ee06b331bd15dfd();
}


} // RL_5c521606738167349ee06b331bd15dfd
}

