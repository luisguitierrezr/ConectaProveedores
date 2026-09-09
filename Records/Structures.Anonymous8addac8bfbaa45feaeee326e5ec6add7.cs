namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (i6zdiqr7_kWu7jJuXsat1w)
///  <code>RC_957af43c68dca2b8260b54a010c3971e</code> that represent
/// s <code>NewDirectionIdNewDivisionIdNewRegionIdRecord</code> <p>Description: </p>
/// </summary>
// Name: NewDirectionIdNewDivisionIdNewRegionIdRecord
public partial struct RC_957af43c68dca2b8260b54a010c3971e : ITypedRecord<RC_957af43c68dca2b8260b54a010c3971e> {
internal static readonly GlobalObjectKey IdNewDirectionId = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*Pl7asli82QJkUKlKKuXRDA");
internal static readonly GlobalObjectKey IdNewDivisionId = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*bA1OMqonPAwvAp8y0Io0VA");
internal static readonly GlobalObjectKey IdNewRegionId = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*ziLvC1Cs8YqhB2OyEeKxtQ");

public ST_52a0b4b2bb66d62c40848f2d472a3986Structure ssSTNewDirectionId;

public ST_52a0b4b2bb66d62c40848f2d472a3986Structure ssSTNewDivisionId;

public ST_52a0b4b2bb66d62c40848f2d472a3986Structure ssSTNewRegionId;


public BitArray OptimizedAttributes;

public RC_957af43c68dca2b8260b54a010c3971e() {
OptimizedAttributes = null;
ssSTNewDirectionId = new ST_52a0b4b2bb66d62c40848f2d472a3986Structure();
ssSTNewDivisionId = new ST_52a0b4b2bb66d62c40848f2d472a3986Structure();
ssSTNewRegionId = new ST_52a0b4b2bb66d62c40848f2d472a3986Structure();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[3];
    all[0] = null;
    all[1] = null;
    all[2] = null;
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    }else{
    ssSTNewDirectionId.OptimizedAttributes = value[0];
    ssSTNewDivisionId.OptimizedAttributes = value[1];
    ssSTNewRegionId.OptimizedAttributes = value[2];
    }
}
get{
    BitArray[] all = new BitArray[3];
    all[0] = null;
    all[1] = null;
    all[2] = null;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssSTNewDirectionId.Read( r, ref index);
ssSTNewDivisionId.Read( r, ref index);
ssSTNewRegionId.Read( r, ref index);
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
public void ReadIM(RC_957af43c68dca2b8260b54a010c3971e r) {
this = r;
}


public static bool operator == (RC_957af43c68dca2b8260b54a010c3971e a, RC_957af43c68dca2b8260b54a010c3971e b) {
if (a.ssSTNewDirectionId != b.ssSTNewDirectionId) return false;
if (a.ssSTNewDivisionId != b.ssSTNewDivisionId) return false;
if (a.ssSTNewRegionId != b.ssSTNewRegionId) return false;
return true;
}

public static bool operator != (RC_957af43c68dca2b8260b54a010c3971e a, RC_957af43c68dca2b8260b54a010c3971e b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_957af43c68dca2b8260b54a010c3971e)) return false;
return (this == (RC_957af43c68dca2b8260b54a010c3971e)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTNewDirectionId.GetHashCode()
 ^ ssSTNewDivisionId.GetHashCode()
 ^ ssSTNewRegionId.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTNewDirectionId.RecursiveReset();
ssSTNewDivisionId.RecursiveReset();
ssSTNewRegionId.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTNewDirectionId.InternalRecursiveSave();
ssSTNewDivisionId.InternalRecursiveSave();
ssSTNewRegionId.InternalRecursiveSave();
}


public RC_957af43c68dca2b8260b54a010c3971e Duplicate() {
RC_957af43c68dca2b8260b54a010c3971e t;
t.ssSTNewDirectionId = (ST_52a0b4b2bb66d62c40848f2d472a3986Structure)this.ssSTNewDirectionId.Duplicate();
t.ssSTNewDivisionId = (ST_52a0b4b2bb66d62c40848f2d472a3986Structure)this.ssSTNewDivisionId.Duplicate();
t.ssSTNewRegionId = (ST_52a0b4b2bb66d62c40848f2d472a3986Structure)this.ssSTNewRegionId.Duplicate();
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
if (head == "newdirectionid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".NewDirectionId")) variable.Value = ssSTNewDirectionId; else variable.Optimized = true;
variable.SetFieldName("newdirectionid");
} else if (head == "newdivisionid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".NewDivisionId")) variable.Value = ssSTNewDivisionId; else variable.Optimized = true;
variable.SetFieldName("newdivisionid");
} else if (head == "newregionid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".NewRegionId")) variable.Value = ssSTNewRegionId; else variable.Optimized = true;
variable.SetFieldName("newregionid");
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
if (key == IdNewDirectionId) {
return ssSTNewDirectionId;
}
if (key == IdNewDivisionId) {
return ssSTNewDivisionId;
}
if (key == IdNewRegionId) {
return ssSTNewRegionId;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdNewDirectionId.Key.AsGuid) {
return ssSTNewDirectionId;
}
if (attributeKey == IdNewDivisionId.Key.AsGuid) {
return ssSTNewDivisionId;
}
if (attributeKey == IdNewRegionId.Key.AsGuid) {
return ssSTNewRegionId;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTNewDirectionId.FillFromOther((IRecord) other.AttributeGet(IdNewDirectionId));
ssSTNewDivisionId.FillFromOther((IRecord) other.AttributeGet(IdNewDivisionId));
ssSTNewRegionId.FillFromOther((IRecord) other.AttributeGet(IdNewRegionId));
}
} // RC_957af43c68dca2b8260b54a010c3971e
/// <summary>
/// RecordList type <code>NewDirectionIdNewDivisionIdNewRegionIdRecordList</code> that represents a
///  record list of <code>LongIntegerIdentifier, LongIntegerIdentifier, LongIntegerIdentifier</code>
/// </summary>
public partial class RL_0688c4264713247af7bc090251768cdb : GenericRecordList<RC_957af43c68dca2b8260b54a010c3971e>, IEnumerable, IEnumerator {

protected override RC_957af43c68dca2b8260b54a010c3971e GetElementDefaultValue() {
return new RC_957af43c68dca2b8260b54a010c3971e();
}

public T[] ToArray<T>(Func<RC_957af43c68dca2b8260b54a010c3971e, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_0688c4264713247af7bc090251768cdb recordList, Func<RC_957af43c68dca2b8260b54a010c3971e, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_0688c4264713247af7bc090251768cdb(RC_957af43c68dca2b8260b54a010c3971e[] array) {
  RL_0688c4264713247af7bc090251768cdb result = new RL_0688c4264713247af7bc090251768cdb();
result.InnerFromArray(array);
    return result;
}

public static RL_0688c4264713247af7bc090251768cdb ToList<T>(T[] array, Func <T, RC_957af43c68dca2b8260b54a010c3971e> converter) {
  RL_0688c4264713247af7bc090251768cdb result = new RL_0688c4264713247af7bc090251768cdb();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_0688c4264713247af7bc090251768cdb FromRestList<T>(RestList<T> restList, Func <T, RC_957af43c68dca2b8260b54a010c3971e> converter) {
  RL_0688c4264713247af7bc090251768cdb result = new RL_0688c4264713247af7bc090251768cdb();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_0688c4264713247af7bc090251768cdb() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[3];
def[0] = null;
def[1] = null;
def[2] = null;
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_957af43c68dca2b8260b54a010c3971e> NewList() {
return new RL_0688c4264713247af7bc090251768cdb();
}


} // RL_0688c4264713247af7bc090251768cdb
}

