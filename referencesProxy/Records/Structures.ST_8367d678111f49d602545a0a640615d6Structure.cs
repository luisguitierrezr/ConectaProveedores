namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [ReferenceStructure] ItemEM_MO (ZcOWXHINdU+BDW9MC3b1sA)
///  <code>ST_8367d678111f49d602545a0a640615d6Structure</code> that represents <code>ItemEM_MO</code
/// > <p>Description: ItemEM_MO</p>
/// </summary>
// Name: ItemEM_MO
public partial struct ST_8367d678111f49d602545a0a640615d6Structure : ITypedRecord<ST_8367d678111f49d602545a0a640615d6Structure> {
internal static readonly GlobalObjectKey IdPOSICION_PEDIDO = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*TTCgsBQA90W5D+VqjTjJIg");
internal static readonly GlobalObjectKey IdMATERIAL = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*ZQ9CguEGWkmJRdJLaqZNVg");
internal static readonly GlobalObjectKey IdCANTIDAD_ENTRADA = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*jmpffn+7BU6gzXnM+GP2Ww");
internal static readonly GlobalObjectKey IdCENTRO = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*f11E9Ga4AUWH_ovq2oNRfQ");
internal static readonly GlobalObjectKey IdALMACEN = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*JLMa28sOXkyO62W3Z652cA");
internal static readonly GlobalObjectKey IdTEXTO_POSICION = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*zar7tHk6DkGRQ5HDMc2c7g");

public string ssPOSICION_PEDIDO;

public string ssMATERIAL;

public string ssCANTIDAD_ENTRADA;

public string ssCENTRO;

public string ssALMACEN;

public string ssTEXTO_POSICION;


public BitArray OptimizedAttributes;

public ST_8367d678111f49d602545a0a640615d6Structure() {
OptimizedAttributes = null;
ssPOSICION_PEDIDO = "";
ssMATERIAL = "";
ssCANTIDAD_ENTRADA = "";
ssCENTRO = "";
ssALMACEN = "";
ssTEXTO_POSICION = "";
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[0];
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    }else{
    }
}
get{
    BitArray[] all = new BitArray[0];
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssPOSICION_PEDIDO = r.ReadText(index++, "ItemEM_MO.POSICION_PEDIDO", "");
ssMATERIAL = r.ReadText(index++, "ItemEM_MO.MATERIAL", "");
ssCANTIDAD_ENTRADA = r.ReadText(index++, "ItemEM_MO.CANTIDAD_ENTRADA", "");
ssCENTRO = r.ReadText(index++, "ItemEM_MO.CENTRO", "");
ssALMACEN = r.ReadText(index++, "ItemEM_MO.ALMACEN", "");
ssTEXTO_POSICION = r.ReadText(index++, "ItemEM_MO.TEXTO_POSICION", "");
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
public void ReadIM(ST_8367d678111f49d602545a0a640615d6Structure r) {
this = r;
}


public static bool operator == (ST_8367d678111f49d602545a0a640615d6Structure a, ST_8367d678111f49d602545a0a640615d6Structure b) {
if (a.ssPOSICION_PEDIDO != b.ssPOSICION_PEDIDO) return false;
if (a.ssMATERIAL != b.ssMATERIAL) return false;
if (a.ssCANTIDAD_ENTRADA != b.ssCANTIDAD_ENTRADA) return false;
if (a.ssCENTRO != b.ssCENTRO) return false;
if (a.ssALMACEN != b.ssALMACEN) return false;
if (a.ssTEXTO_POSICION != b.ssTEXTO_POSICION) return false;
return true;
}

public static bool operator != (ST_8367d678111f49d602545a0a640615d6Structure a, ST_8367d678111f49d602545a0a640615d6Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_8367d678111f49d602545a0a640615d6Structure)) return false;
return (this == (ST_8367d678111f49d602545a0a640615d6Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssPOSICION_PEDIDO.GetHashCode()
 ^ ssMATERIAL.GetHashCode()
 ^ ssCANTIDAD_ENTRADA.GetHashCode()
 ^ ssCENTRO.GetHashCode()
 ^ ssALMACEN.GetHashCode()
 ^ ssTEXTO_POSICION.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_8367d678111f49d602545a0a640615d6Structure Duplicate() {
ST_8367d678111f49d602545a0a640615d6Structure t;
t.ssPOSICION_PEDIDO = this.ssPOSICION_PEDIDO;
t.ssMATERIAL = this.ssMATERIAL;
t.ssCANTIDAD_ENTRADA = this.ssCANTIDAD_ENTRADA;
t.ssCENTRO = this.ssCENTRO;
t.ssALMACEN = this.ssALMACEN;
t.ssTEXTO_POSICION = this.ssTEXTO_POSICION;
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
if (head == "posicion_pedido") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".POSICION_PEDIDO")) variable.Value = ssPOSICION_PEDIDO; else variable.Optimized = true;
} else if (head == "material") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".MATERIAL")) variable.Value = ssMATERIAL; else variable.Optimized = true;
} else if (head == "cantidad_entrada") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CANTIDAD_ENTRADA")) variable.Value = ssCANTIDAD_ENTRADA; else variable.Optimized = true;
} else if (head == "centro") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CENTRO")) variable.Value = ssCENTRO; else variable.Optimized = true;
} else if (head == "almacen") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ALMACEN")) variable.Value = ssALMACEN; else variable.Optimized = true;
} else if (head == "texto_posicion") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TEXTO_POSICION")) variable.Value = ssTEXTO_POSICION; else variable.Optimized = true;
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
if (key == IdPOSICION_PEDIDO) {
return ssPOSICION_PEDIDO;
}
if (key == IdMATERIAL) {
return ssMATERIAL;
}
if (key == IdCANTIDAD_ENTRADA) {
return ssCANTIDAD_ENTRADA;
}
if (key == IdCENTRO) {
return ssCENTRO;
}
if (key == IdALMACEN) {
return ssALMACEN;
}
if (key == IdTEXTO_POSICION) {
return ssTEXTO_POSICION;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdPOSICION_PEDIDO.Key.AsGuid) {
return ssPOSICION_PEDIDO;
}
if (attributeKey == IdMATERIAL.Key.AsGuid) {
return ssMATERIAL;
}
if (attributeKey == IdCANTIDAD_ENTRADA.Key.AsGuid) {
return ssCANTIDAD_ENTRADA;
}
if (attributeKey == IdCENTRO.Key.AsGuid) {
return ssCENTRO;
}
if (attributeKey == IdALMACEN.Key.AsGuid) {
return ssALMACEN;
}
if (attributeKey == IdTEXTO_POSICION.Key.AsGuid) {
return ssTEXTO_POSICION;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssPOSICION_PEDIDO = (string) other.AttributeGet(IdPOSICION_PEDIDO);
ssMATERIAL = (string) other.AttributeGet(IdMATERIAL);
ssCANTIDAD_ENTRADA = (string) other.AttributeGet(IdCANTIDAD_ENTRADA);
ssCENTRO = (string) other.AttributeGet(IdCENTRO);
ssALMACEN = (string) other.AttributeGet(IdALMACEN);
ssTEXTO_POSICION = (string) other.AttributeGet(IdTEXTO_POSICION);
}
} // ST_8367d678111f49d602545a0a640615d6Structure
/// <summary>
/// RecordList type <code>ItemEM_MOList</code> that represents a record list of <code>ItemEM_MO</code>
/// </summary>
public partial class RL_4d0d602433bf72956981903b88f22e91 : GenericRecordList<ST_8367d678111f49d602545a0a640615d6Structure>, IEnumerable, IEnumerator {

protected override ST_8367d678111f49d602545a0a640615d6Structure GetElementDefaultValue() {
return new ST_8367d678111f49d602545a0a640615d6Structure();
}

public T[] ToArray<T>(Func<ST_8367d678111f49d602545a0a640615d6Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_4d0d602433bf72956981903b88f22e91 recordList, Func<ST_8367d678111f49d602545a0a640615d6Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_4d0d602433bf72956981903b88f22e91(ST_8367d678111f49d602545a0a640615d6Structure[] array) {
  RL_4d0d602433bf72956981903b88f22e91 result = new RL_4d0d602433bf72956981903b88f22e91();
result.InnerFromArray(array);
    return result;
}

public static RL_4d0d602433bf72956981903b88f22e91 ToList<T>(T[] array, Func <T, ST_8367d678111f49d602545a0a640615d6Structure> converter) {
  RL_4d0d602433bf72956981903b88f22e91 result = new RL_4d0d602433bf72956981903b88f22e91();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_4d0d602433bf72956981903b88f22e91 FromRestList<T>(RestList<T> restList, Func <T, ST_8367d678111f49d602545a0a640615d6Structure> converter) {
  RL_4d0d602433bf72956981903b88f22e91 result = new RL_4d0d602433bf72956981903b88f22e91();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_4d0d602433bf72956981903b88f22e91() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_8367d678111f49d602545a0a640615d6Structure> NewList() {
return new RL_4d0d602433bf72956981903b88f22e91();
}


} // RL_4d0d602433bf72956981903b88f22e91
}

